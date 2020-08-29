using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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

        //public static MatchResultCalc FromEvents(IList<MatchEvent> events)
        //{

        //}
    }
}
