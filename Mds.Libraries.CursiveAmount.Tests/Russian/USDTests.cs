using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mds.Libraries.CursiveAmount.Tests.Russian
{
    [TestClass]
    public class USDTests
    {
        private ICurrencyFormatter formatter;

        public USDTests()
        {
            formatter = CurrencyFormatterFactory.Build(Language.Russian, Currency.USD);
        }


        [TestMethod]
        public void USDollar()
        {
            var expected = "ноль долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(0));


            expected = "ноль долларов одиннадцать центов";
            Assert.AreEqual(expected, formatter.Build(0.11));

            expected = "ноль долларов двадцать два цента";
            Assert.AreEqual(expected, formatter.Build(0.22));

            expected = "ноль долларов двадцать три цента";
            Assert.AreEqual(expected, formatter.Build(0.23));

            expected = "ноль долларов двадцать четыре цента";
            Assert.AreEqual(expected, formatter.Build(0.24));

            expected = "ноль долларов тридцать центов";
            Assert.AreEqual(expected, formatter.Build(0.3));


            expected = "один доллар двадцать один цент";
            Assert.AreEqual(expected, formatter.Build(1.21));

            expected = "два доллара двадцать два цента";
            Assert.AreEqual(expected, formatter.Build(2.22));

            expected = "три доллара двадцать три цента";
            Assert.AreEqual(expected, formatter.Build(3.23));

            expected = "десять долларов двадцать центов";
            Assert.AreEqual(expected, formatter.Build(10.2));


            expected = "один доллар ноль центов";
            Assert.AreEqual(expected, formatter.Build(1));


            expected = "одна тысяча долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(1000));

            expected = "две тысячи долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(2000));

            expected = "десять тысяч долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(10000));

            expected = "двадцать одна тысяча сто девятнадцать долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(21119));

            expected = "двенадцать тысяч сто девятнадцать долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(12119));


            expected = "один миллион долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(1000000));

            expected = "два миллиона долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(2000000));

            expected = "десять миллионов долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(10000000));


            expected = "один миллиард долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(1000000000));

            expected = "два миллиарда долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(2000000000));

            expected = "три миллиарда долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(3000000000));

            expected = "четыре миллиарда долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(4000000000));

            expected = "пять миллиардов долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(5000000000));

            expected = "шесть миллиардов долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(6000000000));

            expected = "семь миллиардов долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(7000000000));

            expected = "десять миллиардов долларов ноль центов";
            Assert.AreEqual(expected, formatter.Build(10000000000));


            expected = "двести тридцать шесть миллиардов четыреста шестьдесят один миллион семьсот восемьдесят две тысячи девятьсот восемьдесят три доллара двадцать один цент";
            Assert.AreEqual(expected, formatter.Build(236461782983.21));
        }
    }
}
