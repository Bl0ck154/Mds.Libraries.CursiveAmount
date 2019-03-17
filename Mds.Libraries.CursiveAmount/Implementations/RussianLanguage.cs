using Mds.Libraries.CursiveAmount.Implementations.Models;
using Mds.Libraries.CursiveAmount.Interfaces;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations
{
    internal class RussianLanguage : ILanguage
    {
        internal RussianLanguage() { }


        private Dictionary<long, Localizable> Grades { get; } = new Dictionary<long, Localizable>()
        {
            [1000] = new Localizable()
            {
                [1] = "тысяча",
                [2] = "тысячи",
                [3] = "тысячи",
                [4] = "тысячи",
                [11] = "тысяч",
                [12] = "тысяч",
                [13] = "тысяч",
                [14] = "тысяч",
                Default = "тысяч",
                Patcher = (long number, string value) =>
                {
                    switch (number)
                    {
                        case 1:
                            return "одна";
                        case 2:
                            return "две";

                        default:
                            return value;
                    }
                }
            },

            [1000000] = new Localizable()
            {
                [1] = "миллион",
                [2] = "миллиона",
                [3] = "миллиона",
                [4] = "миллиона",
                [11] = "миллионов",
                [12] = "миллионов",
                [13] = "миллионов",
                [14] = "миллионов",
                Default = "миллионов"
            },

            [1000000000] = new Localizable()
            {
                [1] = "миллиард",
                [2] = "миллиарда",
                [3] = "миллиарда",
                [4] = "миллиарда",
                Default = "миллиардов"
            },
        };
        private Dictionary<long, string> Numbers { get; } = new Dictionary<long, string>
        {
            [0] = "ноль",
            [1] = "один",
            [2] = "два",
            [3] = "три",
            [4] = "четыре",
            [5] = "пять",
            [6] = "шесть",
            [7] = "семь",
            [8] = "восемь",
            [9] = "девять",
            [10] = "десять",
            [11] = "одиннадцать",
            [12] = "двенадцать",
            [13] = "тринадцать",
            [14] = "четырнадцать",
            [15] = "пятнадцать",
            [16] = "шестнадцать",
            [17] = "семнадцать",
            [18] = "восемнадцать",
            [19] = "девятнадцать",

            [20] = "двадцать",
            [30] = "тридцать",
            [40] = "сорок",
            [50] = "пятьдесят",
            [60] = "шестьдесят",
            [70] = "семьдесят",
            [80] = "восемьдесят",
            [90] = "девяносто",

            [100] = "сто",
            [200] = "двести",
            [300] = "триста",
            [400] = "четыреста",
            [500] = "пятьсот",
            [600] = "шестьсот",
            [700] = "семьсот",
            [800] = "восемьсот",
            [900] = "девятьсот",
        };


        #region ILanguage
        ICurrencyFormatter ILanguage.RussianRuble
        {
            get
            {
                var formatter = new CurrencyFormatter(Grades, Numbers)
                {
                    MajorCurrency = new Localizable()
                    {
                        [0] = "рублей",
                        [1] = "рубль",
                        [2] = "рубля",
                        [3] = "рубля",
                        [4] = "рубля",
                        [11] = "рублей",
                        [12] = "рублей",
                        [13] = "рублей",
                        [14] = "рублей",
                        Default = "рублей"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [0] = "копеек",
                        [1] = "копейка",
                        [2] = "копейки",
                        [3] = "копейки",
                        [4] = "копейки",
                        [11] = "копеек",
                        [12] = "копеек",
                        [13] = "копеек",
                        [14] = "копеек",
                        Default = "копеек",
                        Patcher = (long number, string value) =>
                        {
                            switch (number)
                            {
                                case 1:
                                    return "одна";
                                case 2:
                                    return "две";

                                default:
                                    return value;
                            }
                        }
                    }
                };

                return formatter;
            }
        }

        ICurrencyFormatter ILanguage.USDollar
        {
            get
            {
                var formatter = new CurrencyFormatter(Grades, Numbers)
                {
                    MajorCurrency = new Localizable()
                    {
                        [0] = "долларов",
                        [1] = "доллар",
                        [2] = "доллара",
                        [3] = "доллара",
                        [4] = "доллара",
                        [11] = "долларов",
                        [12] = "долларов",
                        [13] = "долларов",
                        [14] = "долларов",
                        Default = "долларов"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [0] = "центов",
                        [1] = "цент",
                        [2] = "цента",
                        [3] = "цента",
                        [4] = "цента",
                        [11] = "центов",
                        [12] = "центов",
                        [13] = "центов",
                        [14] = "центов",
                        Default = "цента"
                    }
                };

                return formatter;
            }
        }
        #endregion
    }
}
