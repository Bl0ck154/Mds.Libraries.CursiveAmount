namespace Mds.Libraries.CursiveAmount.Interfaces
{
    public interface ICurrencyFormatter
    {
        string Build(int amount);
        string Build(double amount);
    }
}
