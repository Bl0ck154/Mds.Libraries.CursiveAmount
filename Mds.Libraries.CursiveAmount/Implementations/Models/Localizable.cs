using System;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations.Models
{
    internal class Localizable
    {
        internal Localizable(int divider = 10)
        {
            Default = string.Empty;
            Patcher = (int number, string value) => value;


            Values = new Dictionary<int, string>();
            Divider = divider;
        }



        internal string Default { get; set; }
        internal Func<int, string, string> Patcher { get; set; }

        private Dictionary<int, string> Values { get; }
        private int Divider { get; }

        internal string this[int key]
        {
            set
            {
                Values[key] = value;
            }
        }


        internal string Prepare(int value)
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
