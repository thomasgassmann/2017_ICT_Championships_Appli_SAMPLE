using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace EUFA
{
    public static class Stage
    {
        public const string Group = "GRP";
        public const string RoundOf16 = "R16";
        public const string QuarterFinal = "QFL";
        public const string SemiFinal = "SFL";
        public const string Final = "FIN";

        public static readonly string[] All = new[]
        {
            Stage.Group,
            Stage.RoundOf16,
            Stage.QuarterFinal,
            Stage.SemiFinal,
            Stage.Final
        };

        public static string GetDescription(string stage)
        {
            switch (stage)
            {
                case Stage.Group:
                    return "Group Stage";
                case Stage.RoundOf16:
                    return "Round of 16";
                case Stage.QuarterFinal:
                    return "Quarter-Final";
                case Stage.SemiFinal:
                    return "Semi-Final";
                case Stage.Final:
                    return "Final";
                default:
                    return "wtf is this";
            }
        }

        public static bool StageDone(int tournamentId, string stage)
        {
            var items = new EUFAEntities().Matches.Include(x => x.TournamentParticipation)
                .Where(x => x.TournamentParticipation.TournamentId == tournamentId)
                .Where(x => x.StageCode == stage)
                .Where(x => x.Finished)
                .Count();
            return items == GamesInStage(stage);
        }

        private class Ranking
        {
            public int TeamId { get; set; }

            public int GoalsScored { get; set; }

            public int Random { get; set; }

            public int GoalsDifference { get; set; }

            public int MatchesWon { get; set; }

            public string Group { get; set; }
        }

        public static void Init(int tournamentId, string stage)
        {
            var data = new EUFAEntities();
            var matches = new List<Match>();
            var random = new Random();

            void add(int a, int b, string tag = null) => matches.Add(new Match
            {
                TeamA = a,
                TeamB = b,
                StageCode = stage,
                Tag = tag
            });

            Func<string, int> getWinnerFn(string tagStart)
            {
                var m = data.Matches
                    .Include(x => x.MatchEvents)
                    .Where(x => x.Tag.Length == 3).ToList()
                    .Where(x => x.Tag.StartsWith(tagStart))
                    .ToList();

                int WinnerOf(string s)
                {
                    var cur = m.First(x => x.Tag == s);
                    return MatchResultCalc.Winner(cur, cur.MatchEvents);
                }

                return WinnerOf;
            }

            switch (stage)
            {
                case Stage.Group:
                    var parts = data.TournamentParticipations.Where(x => x.TournamentId == tournamentId).ToList();
                    var byGroup = parts.GroupBy(x => x.GroupLetter);
                    foreach (var group in byGroup)
                    {
                        add(group.First(x => x.GroupNumber == 1).Id, group.First(x => x.GroupNumber == 2).Id);
                        add(group.First(x => x.GroupNumber == 1).Id, group.First(x => x.GroupNumber == 3).Id);
                        add(group.First(x => x.GroupNumber == 3).Id, group.First(x => x.GroupNumber == 4).Id);
                        add(group.First(x => x.GroupNumber == 4).Id, group.First(x => x.GroupNumber == 1).Id);
                        add(group.First(x => x.GroupNumber == 2).Id, group.First(x => x.GroupNumber == 4).Id);
                        add(group.First(x => x.GroupNumber == 2).Id, group.First(x => x.GroupNumber == 3).Id);
                    }

                    break;
                case Stage.RoundOf16:
                    var groupMatches = data.Matches.Where(x => x.TournamentParticipation.TournamentId == tournamentId)
                        .Where(x => x.StageCode == Stage.Group)
                        .Include(x => x.MatchEvents)
                        .Include(x => x.TournamentParticipation)
                        .Include(x => x.TournamentParticipation1)
                        .ToList()
                        .Select(x => new
                        {
                            TeamAId = x.TeamA,
                            TeamBId = x.TeamB,
                            Group = x.TournamentParticipation.GroupLetter,
                            TeamAScore = MatchResultCalc.FromEvents(x, x.MatchEvents).TeamACount,
                            TeamBScore = MatchResultCalc.FromEvents(x, x.MatchEvents).TeamBCount
                        }).ToList();
                    var dict = new Dictionary<string, IList<int>>();
                    var thirdRanked = new List<Ranking>();
                    foreach (var group in groupMatches.GroupBy(x => x.Group))
                    {
                        int MatchesWon(int teamId)
                        {
                            var aWon = group.Where(x => x.TeamAId == teamId && x.TeamAScore > x.TeamBScore);
                            var bWon = group.Where(x => x.TeamBId == teamId && x.TeamBScore > x.TeamAScore);
                            return aWon.Concat(bWon).Distinct().Count();
                        }

                        int GoalsScored(int teamId)
                        {
                            var aScored = group.Where(x => x.TeamAId == teamId).Sum(x => x.TeamAScore);
                            var bScored = group.Where(x => x.TeamBId == teamId).Sum(x => x.TeamBScore);
                            return aScored + bScored;
                        }

                        int GoalsDifference(int teamId)
                        {
                            var aScored = group.Where(x => x.TeamAId == teamId).Sum(x => x.TeamAScore - x.TeamBScore);
                            var bScored = group.Where(x => x.TeamBId == teamId).Sum(x => x.TeamBScore - x.TeamAScore);
                            return aScored + bScored;
                        }

                        var teamsInGroup = group.Select(x => x.TeamAId).Concat(group.Select(x => x.TeamBId)).Distinct().ToList();

                        var rankedTeams = teamsInGroup
                            .Select(x => new Ranking
                            {
                                TeamId = x,
                                MatchesWon = MatchesWon(x),
                                GoalsDifference = GoalsDifference(x),
                                GoalsScored = GoalsScored(x),
                                Random = random.Next(),
                                Group = group.Key
                            })
                            .OrderByDescending(x => x.MatchesWon)
                            .ThenByDescending(x => x.GoalsDifference)
                            .ThenByDescending(x => x.GoalsScored)
                            .ThenBy(x => x.Random)
                            .ToList();

                        thirdRanked.Add(rankedTeams[2]);

                        dict.Add(group.Key, rankedTeams.Select(x => x.TeamId).ToList());
                    }

                    var third = new Dictionary<string, string[]>
                    {
                        { "ABCD", new[] { "C", "D", "A", "B" } },
                        { "ABCE", new[] { "C", "A", "B", "E" } },
                        { "ABCF", new[] { "C", "A", "B", "F" } },
                        {"ABDE", new[]{"D","A","B","E" } },
                        {"ABDF", new[]{"D","A","B","F"}},
                        {"ABEF", new[]{"E","A","B","F"}},
                        {"ACDE", new[]{"C","D","A","E"}},
                        {"ACDF", new[]{"C","D","A","F"}},
                        {"ACEF", new[]{"C","A","F","E"}},
                        {"ADEF", new[]{"D","A","F","E"}},
                        {"BCDE", new[]{"C","D","B","E"}},
                        {"BCDF", new[]{"C","D","B","F"}},
                        {"BCEF", new[]{"E","C","B","F"}},
                        {"BDEF", new[]{"E","D","B","F"}},
                        {"CDEF", new[]{"C","D","F","E"}}
                    };

                    var thirdRankedInOrder = thirdRanked
                        .OrderByDescending(x => x.MatchesWon)
                        .ThenByDescending(x => x.GoalsDifference)
                        .ThenByDescending(x => x.GoalsScored)
                        .Take(4)
                        .ToList();
                    var key = string.Join(string.Empty, thirdRankedInOrder.Select(x => x.Group).ToList());

                    string DetermineThirdGroup(int index)
                    {
                        return third[key][index];
                    }

                    add(dict["A"][1], dict["C"][1], "AF1");
                    add(dict["B"][0], dict[DetermineThirdGroup(1)][2], "AF2");
                    add(dict["D"][0], dict[DetermineThirdGroup(3)][2], "AF3");
                    add(dict["A"][0], dict[DetermineThirdGroup(0)][2], "AF4");
                    add(dict["C"][0], dict[DetermineThirdGroup(2)][2], "AF5");
                    add(dict["F"][0], dict["E"][1], "AF6");
                    add(dict["E"][0], dict["D"][1], "AF7");
                    add(dict["B"][1], dict["F"][1], "AF8");
                    break;
                case Stage.QuarterFinal:
                    var qfWin = getWinnerFn("AF");
                    add(qfWin("AF1"), qfWin("AF3"), "QF1");
                    add(qfWin("AF2"), qfWin("AF6"), "QF2");
                    add(qfWin("AF5"), qfWin("AF7"), "QF3");
                    add(qfWin("AF4"), qfWin("AF8"), "QF4");
                    break;
                case Stage.SemiFinal:
                    var smWin = getWinnerFn("QF");
                    add(smWin("QF1"), smWin("QF2"), "SF1");
                    add(smWin("QF2"), smWin("QF4"), "SF2");
                    break;
                case Stage.Final:
                    var fWin = getWinnerFn("SF");
                    add(fWin("SF1"), fWin("SF2"), "TF1");
                    break;
                default:
                    throw new Exception();
            }

            data.Matches.AddRange(matches);
            data.TrySave();
        }

        public static bool StageInitialized(int tournamentId, string stage)
        {
            var items = new EUFAEntities().Matches.Include(x => x.TournamentParticipation)
                .Where(x => x.TournamentParticipation.TournamentId == tournamentId)
                .Where(x => x.StageCode == stage)
                .Count();
            return items != 0;
        }

        public static int GamesInStage(string stage)
        {
            switch (stage)
            {
                case Stage.Group:
                    return 36;
                case Stage.RoundOf16:
                    return 8;
                case Stage.QuarterFinal:
                    return 4;
                case Stage.SemiFinal:
                    return 2;
                case Stage.Final:
                    return 1;
                default:
                    throw new Exception();
            }
        }

        public static int ToOrder(string stage)
        {
            switch (stage)
            {
                case Stage.Group:
                    return 0;
                case Stage.RoundOf16:
                    return 1;
                case Stage.QuarterFinal:
                    return 2;
                case Stage.SemiFinal:
                    return 3;
                case Stage.Final:
                    return 4;
                default:
                    throw new Exception();
            }
        }

        public static string ToStage(int order)
        {
            switch (order)
            {
                case 0:
                    return Stage.Group;
                case 1:
                    return Stage.RoundOf16;
                case 2:
                    return Stage.QuarterFinal;
                case 3:
                    return Stage.SemiFinal;
                case 4:
                    return Stage.Final;
                default:
                    throw new Exception();
            }
        }
    }
}
