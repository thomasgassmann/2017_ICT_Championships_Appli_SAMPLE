using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EUFA
{
    public class MatchResultCalc
    {
        public int TeamACount { get; set; }

        public int TeamBCount { get; set; }

        public bool IsInProgress { get; set; }

        public bool HasStarted { get; set; }

        public override string ToString()
        {
            if (!HasStarted)
            {
                return "-:-";
            }

            var goals = $"{TeamACount}:{TeamBCount}";
            return IsInProgress ? goals + "*" : goals;
        }

        public static int Winner(Match match, IEnumerable<MatchEvent> results)
        {
            var res = MatchResultCalc.FromEvents(match, results);
            return res.TeamACount > res.TeamBCount ? match.TeamA : match.TeamB;
        }

        public static MatchResultCalc FromEvents(Match match, IEnumerable<MatchEvent> events)
        {
            var matchResult = new MatchResultCalc();

            foreach (var ev in events.Where(x => x.EventType == MatchEventCode.Goal))
            {
                matchResult.TeamACount += ev.TeamA ? 1 : 0;
                matchResult.TeamBCount += ev.TeamA ? 0 : 1;
            }

            matchResult.HasStarted = match.Started;
            matchResult.IsInProgress = match.Started && !match.Finished;

            return matchResult;
        }
    }
}
