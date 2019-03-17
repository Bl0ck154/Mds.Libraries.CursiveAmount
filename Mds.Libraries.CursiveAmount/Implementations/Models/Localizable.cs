using System;
using System.Collections.Generic;
using System.Linq;

namespace Mds.Libraries.CursiveAmount.Implementations.Models
{
    internal class Localizable
    {
        internal Localizable()
        {
            Default = string.Empty;
            Patcher = (long number, string value) => value;


            Values = new Dictionary<long, string>();
        }



        internal string Default { get; set; }
        internal Func<long, string, string> Patcher { get; set; }

        private Dictionary<long, string> Values { get; }

        internal string this[long key]
        {
            set
            {
                Values[key] = value;
            }
        }


        internal string Prepare(long value)
        {
            var stringed = value.ToString();
            var keys = Values.Keys.OrderByDescending(k => k)
                                  .Select(k => k.ToString());

            foreach (var key in keys)
            {
                if (stringed.EndsWith(key))
                {
                    return Values[Convert.ToInt64(key)];
                }
            }

            return Default;
        }
    }
}
