using Mds.Libraries.CursiveAmount.Interfaces;
using System.Collections.Generic;

namespace Mds.Libraries.CursiveAmount.Implementations.Models
{
    internal class CurrencyFormatter : ICurrencyFormatter
    {
        private readonly Dictionary<int, Localizable> grades;
        private readonly Dictionary<int, string> numbers;

        internal CurrencyFormatter(Dictionary<int, Localizable> grades, Dictionary<int, string> numbers)
        {
            this.grades = grades;
            this.numbers = numbers;
        }


        internal Localizable MajorCurrency { get; set; }
        internal Localizable MinorCurrency { get; set; }


        string ICurrencyFormatter.Build(int amount)
        {
            throw new System.NotImplementedException();
        }

        string ICurrencyFormatter.Build(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
}
