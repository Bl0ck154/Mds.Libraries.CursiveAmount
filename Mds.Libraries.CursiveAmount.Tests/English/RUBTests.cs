using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mds.Libraries.CursiveAmount.Tests.English
{
    [TestClass]
    public class RUBTests
    {
        private ICurrencyFormatter formatter;

        public RUBTests()
        {
            formatter = CurrencyFormatterFactory.Build(Language.English, Currency.RUB);
        }


        [TestMethod]
        public void RussianRUB()
        {
            var expected = "zero rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(0));


            expected = "zero rubles eleven kopecks";
            Assert.AreEqual(expected, formatter.Build(0.11));

            expected = "zero rubles twenty two kopecks";
            Assert.AreEqual(expected, formatter.Build(0.22));

            expected = "zero rubles twenty three kopecks";
            Assert.AreEqual(expected, formatter.Build(0.23));

            expected = "zero rubles twenty four kopecks";
            Assert.AreEqual(expected, formatter.Build(0.24));

            expected = "zero rubles thirty kopecks";
            Assert.AreEqual(expected, formatter.Build(0.3));


            expected = "one ruble twenty one kopecks";
            Assert.AreEqual(expected, formatter.Build(1.21));

            expected = "two rubles twenty two kopecks";
            Assert.AreEqual(expected, formatter.Build(2.22));

            expected = "three rubles twenty three kopecks";
            Assert.AreEqual(expected, formatter.Build(3.23));

            expected = "ten rubles twenty kopecks";
            Assert.AreEqual(expected, formatter.Build(10.2));


            expected = "one ruble zero kopecks";
            Assert.AreEqual(expected, formatter.Build(1));


            expected = "one thousand rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(1000));

            expected = "two thousands rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(2000));

            expected = "ten thousands rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(10000));

            expected = "twenty one thousands one hundred nineteen rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(21119));

            expected = "twelve thousands one hundred nineteen rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(12119));


            expected = "one million rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(1000000));

            expected = "two millions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(2000000));

            expected = "ten millions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(10000000));


            expected = "one billion rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(1000000000));

            expected = "two billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(2000000000));

            expected = "three billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(3000000000));

            expected = "four billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(4000000000));

            expected = "five billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(5000000000));

            expected = "six billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(6000000000));

            expected = "seven billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(7000000000));

            expected = "ten billions rubles zero kopecks";
            Assert.AreEqual(expected, formatter.Build(10000000000));


            expected = "two hundred thirty six billions four hundred sixty one millions seven hundred eighty two thousands nine hundred eighty three rubles twenty one kopecks";
            Assert.AreEqual(expected, formatter.Build(236461782983.21));
        }
    }
}
