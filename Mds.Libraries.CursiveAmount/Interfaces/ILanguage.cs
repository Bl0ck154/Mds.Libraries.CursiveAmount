namespace Mds.Libraries.CursiveAmount.Interfaces
{
    internal interface ILanguage
    {
        ICurrencyFormatter RussianRuble { get; }
        ICurrencyFormatter USDollar { get; }
    }
}
