using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class Specials : ComponentBase
    {
        [Inject]
        GetSpecialsViewModel viewModel { get; set; }

        override protected async Task OnInitializedAsync()
        {
            await viewModel.GetSpecialsAsync();
        }
    }
}