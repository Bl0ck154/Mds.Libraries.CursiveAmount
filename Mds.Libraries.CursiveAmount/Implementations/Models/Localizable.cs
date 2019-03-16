using System;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations.Models
{
    internal class Localizable
    {
        internal Localizable(int divider = 10)
        {
            Default = string.Empty;
            Patcher = (long number, string value) => value;


            Values = new Dictionary<long, string>();
            Divider = divider;
        }



        internal string Default { get; set; }
        internal Func<long, string, string> Patcher { get; set; }

        private Dictionary<long, string> Values { get; }
        private int Divider { get; }

        internal string this[long key]
        {
            set
            {
                Values[key] = value;
            }
        }


        internal string Prepare(long value)
        {
            value = value % Divider;

            if (Values.ContainsKey(value))
            {
                return Values[value];
            }
            else
            {
                return Default;
            }
        }
    }
}
