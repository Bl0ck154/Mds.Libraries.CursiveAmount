using Mds.Libraries.CursiveAmount.Implementations;
using Mds.Libraries.CursiveAmount.Interfaces;
using Mds.Libraries.CursiveAmount.Models;

namespace Mds.Libraries.CursiveAmount
{
    public static class CurrencyFormatterFactory
    {
        public static ICurrencyFormatter Build(Language language, Currency currency)
        {
            var lang = Build(language);

            switch (currency)
            {
                case Currency.RUB:
                    return lang.RussianRuble;

                case Currency.USD:
                    return lang.RussianRuble;

                default:
                    return default(ICurrencyFormatter);
            }
        }
        private static ILanguage Build(Language language)
        {
            switch (language)
            {
                case Language.Russian:
                    return new RussianLanguage();

                case Language.English:
                    return new EnglishLanguage();

                default:
                    return default(ILanguage);
            }
        }
    }
}
