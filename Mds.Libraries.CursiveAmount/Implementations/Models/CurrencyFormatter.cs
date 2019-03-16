using Mds.Libraries.CursiveAmount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mds.Libraries.CursiveAmount.Implementations.Models
{
    internal class CurrencyFormatter : ICurrencyFormatter
    {
        private readonly Dictionary<long, Localizable> grades;
        private readonly Dictionary<long, string> numbers;


        internal CurrencyFormatter(Dictionary<long, Localizable> grades, Dictionary<long, string> numbers)
        {
            this.grades = grades;
            this.numbers = numbers;
        }


        internal Localizable MajorCurrency { get; set; }
        internal Localizable MinorCurrency { get; set; }


        #region ICurrencyFormatter
        string ICurrencyFormatter.Build(long amount) => (this as ICurrencyFormatter).Build(Convert.ToDouble(amount));
        string ICurrencyFormatter.Build(double amount)
        {
            amount = Math.Abs(amount);

            var @decimal = (long)Math.Floor(amount);
            var @float = Convert.ToInt64(Math.Round(100 * amount)) % 100;

            var values = new List<string>();


            foreach (var pair in ParseOnGrades(@decimal))
            {
                var converted = ConvertGrade(pair.Key, pair.Value, false, false);
                values.AddRange(converted);
            }

            values.AddRange(ConvertGrade(@decimal % 1000, MajorCurrency, true, !values.Any()));
            values.AddRange(ConvertGrade(@float, MinorCurrency, true, true));


            var filtered = values.Where(v => !string.IsNullOrEmpty(v));
            return string.Join(" ", filtered.ToArray());
        }
        private IEnumerable<KeyValuePair<long, Localizable>> ParseOnGrades(long @decimal)
        {
            var filtered = grades.Keys.Where(v => v <= @decimal);
            if (!filtered.Any())
            {
                yield break;
            }


            var degree = filtered.Max();
            while (degree >= 1000)
            {
                var value = @decimal / degree;

                yield return new KeyValuePair<long, Localizable>(value, grades[degree]);

                @decimal -= (value * degree);
                degree /= 1000;
            }
        }
        private IEnumerable<string> ConvertGrade(long value, Localizable localizable, bool showZero, bool isMust)
        {
            var hundred = value / 100;
            var ten = (value - hundred * 100) / 10;
            var one = value % 10;


            if (0 != hundred)
            {
                yield return Localize(hundred * 100, localizable);
            }

            if (0 != ten)
            {
                yield return Localize(ten * 10, localizable);
            }

            if (0 != one || (0 == hundred && 0 == ten && isMust))
            {
                yield return Localize(one, localizable);
            }

            if (0 != value || showZero)
            {
                yield return localizable.Prepare(value);
            }
        }
        private string Localize(long value, Localizable localizable)
        {
            var result = numbers[value];
            result = localizable.Patcher(value, result);

            return result;
        }
        #endregion
    }
}
