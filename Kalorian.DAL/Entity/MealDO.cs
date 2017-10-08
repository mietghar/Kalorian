using Kalorian.Common.Utility.Common;
using System;

namespace Kalorian.DAL.Entity
{
    public class MealDO : IIdentifiable
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Weight { get; set; }
        public DateTime MealTimeStamp { get; set; }
    }
}
