using Mds.Libraries.CursiveAmount.Implementations.Models;
using Mds.Libraries.CursiveAmount.Interfaces;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations
{
    internal class RussianLanguage : ILanguage
    {
        internal RussianLanguage() { }


        public ICurrencyFormatter RussianRuble
        {
            get
            {
                var formatter = new CurrencyFormatter(grades, numbers)
                {
                    MajorCurrency = new Localizable()
                    {
                        [0] = "рублей",
                        [1] = "рубль",
                        Default = "рубля"
                    },
                    MinorCurrency = new Localizable()
                    {
                        [0] = "копеек",
                        [1] = "копейка",
                        Default = "копейки",
                        Patcher = (int number, string value) =>
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


        private Dictionary<int, Localizable> grades { get; } = new Dictionary<int, Localizable>()
        {
            [1000] = new Localizable()
            {
                [0] = "тысяч",
                [1] = "тысяча",
                Default = "тысячи"
            },

            [1000000] = new Localizable()
            {
                [0] = "миллионов",
                [1] = "миллион",
                Default = "миллиона"
            },

            [1000000000] = new Localizable()
            {
                [0] = "миллиардов",
                [1] = "миллиард",
                Default = "миллиарда"
            },
        };
        private Dictionary<int, string> numbers { get; } = new Dictionary<int, string>
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
    }
}
