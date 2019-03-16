using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mds.Libraries.CursiveAmount.Tests.Russian
{
    [TestClass]
    public class RUBTests
    {
        private ICurrencyFormatter formatter;

        public RUBTests()
        {
            formatter = CurrencyFormatterFactory.Build(Language.Russian, Currency.RUB);
        }


        [TestMethod]
        public void RussianRUB()
        {
            var expected = "ноль рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(0));


            expected = "один рубль двадцать одна копейка";
            Assert.AreEqual(expected, formatter.Build(1.21));

            expected = "два рубля двадцать две копейки";
            Assert.AreEqual(expected, formatter.Build(2.22));

            expected = "три рубля двадцать три копейки";
            Assert.AreEqual(expected, formatter.Build(3.23));

            expected = "десять рублей двадцать копеек";
            Assert.AreEqual(expected, formatter.Build(10.2));


            expected = "один рубль ноль копеек";
            Assert.AreEqual(expected, formatter.Build(1));


            expected = "одна тысяча рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(1000));

            expected = "две тысячи рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(2000));

            expected = "десять тысяч рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(10000));


            expected = "один миллион рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(1000000));

            expected = "два миллиона рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(2000000));

            expected = "десять миллионов рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(10000000));


            expected = "один миллиард рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(1000000000));

            expected = "два миллиарда рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(2000000000));

            expected = "три миллиарда рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(3000000000));

            expected = "четыре миллиарда рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(4000000000));

            expected = "пять миллиардов рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(5000000000));

            expected = "шесть миллиардов рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(6000000000));

            expected = "семь миллиардов рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(7000000000));

            expected = "десять миллиардов рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(10000000000));


            expected = "двести тридцать шесть миллиардов четыреста шестьдесят один миллион семьсот восемьдесят две тысячи девятьсот восемьдесят три рубля двадцать одна копейка";
            Assert.AreEqual(expected, formatter.Build(236461782983.21));
        }
    }
}
