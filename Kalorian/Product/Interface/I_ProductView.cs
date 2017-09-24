namespace Kalorian.Product.Interface
{
    public interface I_ProductView
    {
        string ProductName { get; }
        decimal KcalPerGramm { get; }
        decimal Fat { get; }
        decimal Carbo { get; }
        decimal Whey { get; }
        decimal Salt { get; }
    }
}
