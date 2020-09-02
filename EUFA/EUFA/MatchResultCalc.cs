using EUFA.Data;
using System.Collections.Generic;
using System.Linq;

namespace EUFA
{
    public class MatchResultCalc
    {
        public int TeamACount { get; set; }

        public int TeamBCount { get; set; }

        public int TeamAPenalty { get; set; }

        public int TeamBPenalty { get; set; }

        public bool IsInProgress { get; set; }

        public bool HasStarted { get; set; }

        public Match Match { get; set; }

        public override string ToString()
        {
            if (!HasStarted)
            {
                return "-:-";
            }

            var goals = $"{TeamACount}:{TeamBCount}";
            return IsInProgress ? goals + "*" : goals;
        }

        public string OverViewA()
        {
            return Overview(true);
        }

        public string OverViewB()
        {
            return Overview(false);
        }

        public string Overview()
        {
            return $"{OverViewA()} - {OverViewB()}";
        }

        private string Overview(bool teamA)
        {
            if (IsInProgress)
            {
                return "-";
            }

            var count = teamA ? TeamACount : TeamBCount;
            var penalty = teamA ? TeamAPenalty : TeamBPenalty;
            if (TeamACount == TeamBCount)
            {
                return $"{count} ({penalty})";
            }

            return $"{TeamACount}";
        }

        public static int Winner(Match match, IEnumerable<MatchEvent> results)
        {
            var res = MatchResultCalc.FromEvents(match, results);
            if (res.IsInProgress || res.TeamACount == res.TeamBCount)
            {
                return -1;
            }

            return res.TeamACount > res.TeamBCount ? match.TeamA : match.TeamB;
        }

        public static MatchResultCalc FromEvents(Match match, IEnumerable<MatchEvent> events)
        {
            var matchResult = new MatchResultCalc
            {
                Match = match
            };

            foreach (var ev in events.Where(x => x.EventType == MatchEventCode.Goal || x.EventType == MatchEventCode.Penalty))
            {
                if (ev.EventType == MatchEventCode.Goal)
                {
                    matchResult.TeamACount += ev.TeamA ? 1 : 0;
                    matchResult.TeamBCount += ev.TeamA ? 0 : 1;
                }
                else
                {
                    matchResult.TeamAPenalty += ev.TeamA ? 1 : 0;
                    matchResult.TeamBPenalty += ev.TeamA ? 0 : 1;
                }
            }

            matchResult.HasStarted = match.Started;
            matchResult.IsInProgress = match.Started && !match.Finished;

            return matchResult;
        }
    }
}
