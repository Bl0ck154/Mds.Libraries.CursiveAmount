﻿using Mds.Libraries.CursiveAmount.Implementations.Models;
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
                [2] = "thousands",
                [3] = "thousands",
                [4] = "thousands",
                [11] = "thousands",
                [12] = "thousands",
                [13] = "thousands",
                [14] = "thousands",
                [21] = "thousands",
                [31] = "thousands",
                [41] = "thousands",
                [51] = "thousands",
                [61] = "thousands",
                [71] = "thousands",
                [81] = "thousands",
                [91] = "thousands",
                Default = "thousands"
            },

            [1000000] = new Localizable()
            {
                [1] = "million",
                [2] = "millions",
                [3] = "millions",
                [4] = "millions",
                [11] = "millions",
                [12] = "millions",
                [13] = "millions",
                [14] = "millions",
                [21] = "millions",
                [31] = "millions",
                [41] = "millions",
                [51] = "millions",
                [61] = "millions",
                [71] = "millions",
                [81] = "millions",
                [91] = "millions",
                Default = "millions"
            },

            [1000000000] = new Localizable()
            {
                [1] = "billion",
                [2] = "billions",
                [3] = "billions",
                [4] = "billions",
                [11] = "billions",
                [12] = "billions",
                [13] = "billions",
                [14] = "billions",
                [21] = "billions",
                [31] = "billions",
                [41] = "billions",
                [51] = "billions",
                [61] = "billions",
                [71] = "billions",
                [81] = "billions",
                [91] = "billions",
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
                        [2] = "dollars",
                        [3] = "dollars",
                        [4] = "dollars",
                        [11] = "dollars",
                        [12] = "dollars",
                        [13] = "dollars",
                        [14] = "dollars",
                        [21] = "dollars",
                        [31] = "dollars",
                        [41] = "dollars",
                        [51] = "dollars",
                        [61] = "dollars",
                        [71] = "dollars",
                        [81] = "dollars",
                        [91] = "dollars",
                        Default = "dollars"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [1] = "cent",
                        [2] = "cents",
                        [3] = "cents",
                        [4] = "cents",
                        [11] = "cents",
                        [12] = "cents",
                        [13] = "cents",
                        [14] = "cents",
                        [21] = "cents",
                        [31] = "cents",
                        [41] = "cents",
                        [51] = "cents",
                        [61] = "cents",
                        [71] = "cents",
                        [81] = "cents",
                        [91] = "cents",
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
                        [2] = "rubles",
                        [3] = "rubles",
                        [4] = "rubles",
                        [11] = "rubles",
                        [12] = "rubles",
                        [13] = "rubles",
                        [14] = "rubles",
                        [21] = "rubles",
                        [31] = "rubles",
                        [41] = "rubles",
                        [51] = "rubles",
                        [61] = "rubles",
                        [71] = "rubles",
                        [81] = "rubles",
                        [91] = "rubles",
                        Default = "rubles"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [1] = "kopek",
                        [2] = "kopecks",
                        [3] = "kopecks",
                        [4] = "kopecks",
                        [11] = "kopecks",
                        [12] = "kopecks",
                        [13] = "kopecks",
                        [14] = "kopecks",
                        [21] = "kopecks",
                        [31] = "kopecks",
                        [41] = "kopecks",
                        [51] = "kopecks",
                        [61] = "kopecks",
                        [71] = "kopecks",
                        [81] = "kopecks",
                        [91] = "kopecks",
                        Default = "kopecks"
                    }
                };

                return formatter;
            }
        }
        #endregion
    }
}
