using System;

namespace Kalorian.Meal.Interface
{
    public interface I_MealView
    {
        DateTime MealTimeStamp { get; }
        int ProductId { get; }
        decimal Weight { get; }
    }
}
