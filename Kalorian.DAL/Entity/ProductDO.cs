using Kalorian.Common.Utility.Common;

namespace Kalorian.DAL.Entity
{
    public class ProductDO : IIdentifiable
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal KcalPer100Gramm { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbo { get; set; }
        public decimal Whey { get; set; }
        public decimal Salt { get; set; }
    }
}
