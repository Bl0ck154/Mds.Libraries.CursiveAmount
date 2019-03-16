using Mds.Libraries.CursiveAmount.Interfaces;

namespace Mds.Libraries.CursiveAmount.Implementations
{
    internal class RussianLanguage : ILanguage
    {
        internal RussianLanguage()
        {
            RussianRuble = null;
        }

        public ICurrencyFormatter RussianRuble { get; private set; }
    }
}
