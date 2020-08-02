using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUFA
{
    public class KeyWithView
    {
        public KeyWithView(object key, string value)
        {
            Key = key;
            Value = value;
        }

        public object Key { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
