using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Aggregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Index
{
    public class IndexViewModel(IOptions<BlazingPizzaOptions> options,
        ShoppingCart shoppingCart)
    {
        public CustomPizza CustomPizza { get; set; }
        public bool ShowConfigurePizzaDialog { get; set; }

        public void ConfigurePizza(PizzaSpecialDto special)
        {
            CustomPizza = new CustomPizza(special, options.Value);
            ShowConfigurePizzaDialog = true;
        }

        public void CancelConfigurePizza()
        {
            CustomPizza = null;
            ShowConfigurePizzaDialog = false;
        }

        public void ConfirmConfigurePizza()
        {
            shoppingCart.AddPizza(CustomPizza);
            foreach (var Pizza in shoppingCart.Pizzas)
            {
                Console.WriteLine(Pizza.Special.Name);
            }
            
            CustomPizza = null;
            ShowConfigurePizzaDialog = false;
        }
    }
}
