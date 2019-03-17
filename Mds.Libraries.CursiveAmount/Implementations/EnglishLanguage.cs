using Mds.Libraries.CursiveAmount.Implementations.Models;
using Mds.Libraries.CursiveAmount.Interfaces;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations
{
    internal class EnglishLanguage : ILanguage
    {
        internal EnglishLanguage() { }


        private Dictionary<long, Localizable> Grades { get; } = new Dictionary<long, Localizable>()
        {
            [1000] = new Localizable()
            {
                [1] = "thousand",
                Default = "thousands"
            },

            [1000000] = new Localizable()
            {
                [1] = "million",
                Default = "millions"
            },

            [1000000000] = new Localizable()
            {
                [1] = "billion",
                Default = "billions"
            },
        };
        private Dictionary<long, string> Numbers { get; } = new Dictionary<long, string>
        {
            [0] = "zero",
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [10] = "ten",
            [11] = "eleven",
            [12] = "twelve",
            [13] = "thirteen",
            [14] = "fourteen",
            [15] = "fiveteen",
            [16] = "sixteen",
            [17] = "seventeen",
            [18] = "eighteen",
            [19] = "nineteen",

            [20] = "twenty",
            [30] = "thirty",
            [40] = "fourty",
            [50] = "fifty",
            [60] = "sixty",
            [70] = "seventy",
            [80] = "eighty",
            [90] = "ninety",

            [100] = "one hundred",
            [200] = "two hundred",
            [300] = "three hundred",
            [400] = "four hundred",
            [500] = "five hundred",
            [600] = "six hundred",
            [700] = "seven hundred",
            [800] = "eight hundred",
            [900] = "nine hundred",
        };


        #region ILanguage
        ICurrencyFormatter ILanguage.USDollar
        {
            get
            {
                var formatter = new CurrencyFormatter(Grades, Numbers)
                {
                    MajorCurrency = new Localizable()
                    {
                        [1] = "dollar",
                        Default = "dollars"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [1] = "cent",
                        Default = "cents"
                    }
                };

                return formatter;
            }
        }

        ICurrencyFormatter ILanguage.RussianRuble
        {
            get
            {
                var formatter = new CurrencyFormatter(Grades, Numbers)
                {
                    MajorCurrency = new Localizable()
                    {
                        [1] = "ruble",
                        Default = "rubles"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [1] = "kopek",
                        Default = "kopecks"
                    }
                };

                return formatter;
            }
        }
        #endregion
    }
}
