using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog
{
    internal class ConfigurePizzaDialogViewModel(
        IGetToppingsModel toppingsModel)

    {
        public IEnumerable<ToppingDto> Toppings { get; private set; }

        public async Task GetToppings() =>
            Toppings = await toppingsModel.GetToppingsAsync();
    }
}
