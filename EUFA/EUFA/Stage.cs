using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                .Where(x => x.Finished.Value)
                .Count();
            return items == GamesInStage(stage);
        }

        public static void Init(int tournamentId, string stage)
        {
            var data = new EUFAEntities();
            switch (stage)
            {
                case Stage.Group:
                    var parts = data.TournamentParticipations.Where(x => x.TournamentId == tournamentId).ToList();
                    var byGroup = parts.GroupBy(x => x.GroupLetter);
                    var matches = new List<Match>();
                    foreach (var group in byGroup)
                    {
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 1).Id,
                            TeamB = group.First(x => x.GroupNumber == 2).Id,
                            StageCode = Stage.Group
                        });
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 1).Id,
                            TeamB = group.First(x => x.GroupNumber == 3).Id,
                            StageCode = Stage.Group
                        });
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 3).Id,
                            TeamB = group.First(x => x.GroupNumber == 4).Id,
                            StageCode = Stage.Group
                        });
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 4).Id,
                            TeamB = group.First(x => x.GroupNumber == 1).Id,
                            StageCode = Stage.Group
                        });
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 2).Id,
                            TeamB = group.First(x => x.GroupNumber == 4).Id,
                            StageCode = Stage.Group
                        });
                        matches.Add(new Match
                        {
                            TeamA = group.First(x => x.GroupNumber == 2).Id,
                            TeamB = group.First(x => x.GroupNumber == 3).Id,
                            StageCode = Stage.Group
                        });
                    }

                    data.Matches.AddRange(matches);
                    data.TrySave();
                    return;
                default:
                    throw new Exception();
            }
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
