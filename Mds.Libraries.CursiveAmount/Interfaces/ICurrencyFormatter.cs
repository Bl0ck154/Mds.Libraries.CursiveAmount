namespace Mds.Libraries.CursiveAmount.Interfaces
{
    public interface ICurrencyFormatter
    {
        string Build(long amount);
        string Build(double amount);
    }
}
