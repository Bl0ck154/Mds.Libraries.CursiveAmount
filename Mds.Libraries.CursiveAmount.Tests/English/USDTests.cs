using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mds.Libraries.CursiveAmount.Tests.English
{
    [TestClass]
    public class USDTests
    {
        private ICurrencyFormatter formatter;

        public USDTests()
        {
            formatter = CurrencyFormatterFactory.Build(Language.English, Currency.USD);
        }


        [TestMethod]
        public void USDollar()
        {
            var expected = "zero dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(0));


            expected = "zero dollars eleven cents";
            Assert.AreEqual(expected, formatter.Build(0.11));

            expected = "zero dollars twenty two cents";
            Assert.AreEqual(expected, formatter.Build(0.22));

            expected = "zero dollars twenty three cents";
            Assert.AreEqual(expected, formatter.Build(0.23));

            expected = "zero dollars twenty four cents";
            Assert.AreEqual(expected, formatter.Build(0.24));

            expected = "zero dollars thirty cents";
            Assert.AreEqual(expected, formatter.Build(0.3));


            expected = "one dollar twenty one cents";
            Assert.AreEqual(expected, formatter.Build(1.21));

            expected = "two dollars twenty two cents";
            Assert.AreEqual(expected, formatter.Build(2.22));

            expected = "three dollars twenty three cents";
            Assert.AreEqual(expected, formatter.Build(3.23));

            expected = "ten dollars twenty cents";
            Assert.AreEqual(expected, formatter.Build(10.2));


            expected = "one dollar zero cents";
            Assert.AreEqual(expected, formatter.Build(1));


            expected = "one thousand dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(1000));

            expected = "two thousands dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(2000));

            expected = "ten thousands dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(10000));

            expected = "twenty one thousands one hundred nineteen dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(21119));

            expected = "twelve thousands one hundred nineteen dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(12119));


            expected = "one million dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(1000000));

            expected = "two millions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(2000000));

            expected = "ten millions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(10000000));


            expected = "one billion dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(1000000000));

            expected = "two billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(2000000000));

            expected = "three billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(3000000000));

            expected = "four billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(4000000000));

            expected = "five billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(5000000000));

            expected = "six billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(6000000000));

            expected = "seven billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(7000000000));

            expected = "ten billions dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(10000000000));


            expected = "two hundred thirty six billions four hundred sixty one millions seven hundred eighty two thousands nine hundred eighty three dollars twenty one cents";
            Assert.AreEqual(expected, formatter.Build(236461782983.21));
        }

        [TestMethod]
        public void USDollarPrecedent()
        {
            var expected = "two dollars fifteen cents";
            Assert.AreEqual(expected, formatter.Build(2.15));

            expected = "three dollars sixteen cents";
            Assert.AreEqual(expected, formatter.Build(3.16));

            expected = "four dollars twenty six cents";
            Assert.AreEqual(expected, formatter.Build(4.26));

            expected = "twenty seven dollars twenty eight cents";
            Assert.AreEqual(expected, formatter.Build(27.28));
        }
    }
}
