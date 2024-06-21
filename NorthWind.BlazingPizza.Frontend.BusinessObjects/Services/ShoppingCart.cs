using NorthWind.BlazingPizza.Frontend.BusinessObjects.Aggregates;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Services
{
    public class ShoppingCart
    {
         readonly List<CustomPizza> PizzaField=[];

         public IEnumerable<CustomPizza> Pizzas => PizzaField;

         public void AddPizza(CustomPizza pizza) =>
             PizzaField.Add(pizza);

         public void RemovePizza(CustomPizza pizza) =>
             PizzaField.Remove(pizza);

         public void ResetShoppingCart() 
         {
             PizzaField.Clear();
         }

         public decimal GetTotalPrice() =>
             PizzaField.Sum(p => p.GetTotalPrice());

         public string GetFormattedTotalPrice() =>
             GetTotalPrice().ToString("0.00");

         public bool HasPizzas => PizzaField.Any();
    }
}
