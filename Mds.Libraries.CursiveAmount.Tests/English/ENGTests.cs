using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mds.Libraries.CursiveAmount.Tests.Russian
{
    [TestClass]
    public class ENGTests
    {
        private ICurrencyFormatter formatter;

        public ENGTests()
        {
            formatter = CurrencyFormatterFactory.Build(Language.English, Currency.USD);
        }


        [TestMethod]
        public void USDollar()
        {
            var expected = "zero dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(0));

            expected = "three hundred dollars zero cents";
            Assert.AreEqual(expected, formatter.Build(300));

            expected = "one dollar twenty one cent";
            Assert.AreEqual(expected, formatter.Build(1.21));

            expected = "two dollars twenty one cent";
            Assert.AreEqual(expected, formatter.Build(2.21));

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


            expected = "two hundred thirty six billions four hundred sixty one million seven hundred eighty two thousands nine hundred eighty three dollars twenty one cent";
            Assert.AreEqual(expected, formatter.Build(236461782983.21));
        }
    }
}
