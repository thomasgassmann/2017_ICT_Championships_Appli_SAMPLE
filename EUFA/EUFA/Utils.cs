using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUFA
{
    public static class Utils
    {
        public static string FormatFromTo(DateTime from, DateTime to)
        {
            return $"{from.ToShortDateString()} - {to.ToShortDateString()}";
        }
    }
}
