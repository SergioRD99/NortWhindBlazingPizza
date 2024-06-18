using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Aggregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Index
{
    public class IndexViewModel(IOptions<BlazingPizzaOptions> options)
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
            CustomPizza = null;
            ShowConfigurePizzaDialog = false;
        }
    }
}
