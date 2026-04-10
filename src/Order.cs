using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();

public void AddToOrder(Dish dish)
{
    dishes.Add(dish);
}
        public void Clear()
        {
            dishes.Clear();
        }

public bool HasOrders()
{
    return dishes.Count > 0;
}

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in dishes)
            {
                total += dish.Price;
            }
            return total;
        }
    }
}