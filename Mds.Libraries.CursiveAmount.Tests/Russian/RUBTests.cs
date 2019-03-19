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


            expected = "ноль рублей одиннадцать копеек";
            Assert.AreEqual(expected, formatter.Build(0.11));

            expected = "ноль рублей двадцать две копейки";
            Assert.AreEqual(expected, formatter.Build(0.22));

            expected = "ноль рублей двадцать три копейки";
            Assert.AreEqual(expected, formatter.Build(0.23));

            expected = "ноль рублей двадцать четыре копейки";
            Assert.AreEqual(expected, formatter.Build(0.24));

            expected = "ноль рублей тридцать копеек";
            Assert.AreEqual(expected, formatter.Build(0.3));


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

            expected = "двадцать одна тысяча сто девятнадцать рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(21119));

            expected = "двенадцать тысяч сто девятнадцать рублей ноль копеек";
            Assert.AreEqual(expected, formatter.Build(12119));


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
        
        [TestMethod]
        public void RussianRUBPrecedent()
        {
            var expected = "два рубля пятнадцать копеек";
            Assert.AreEqual(expected, formatter.Build(2.15));

            expected = "три рубля шестнадцать копеек";
            Assert.AreEqual(expected, formatter.Build(3.16));

            expected = "четыре рубля двадцать шесть копеек";
            Assert.AreEqual(expected, formatter.Build(4.26));

            expected = "двадцать семь рублей двадцать восемь копеек";
            Assert.AreEqual(expected, formatter.Build(27.28));
        }
    }
}
