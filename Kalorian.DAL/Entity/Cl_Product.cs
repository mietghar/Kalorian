namespace Kalorian.DAL.Entity
{
    public class Cl_Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal KcalPerGramm { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbo { get; set; }
        public decimal Whey { get; set; }
        public decimal Salt { get; set; }
    }
}
