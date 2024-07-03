using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Orders;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Orders
    {
        [Inject]
        OrdersViewModel ViewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetOrderAsnc(); 
        }
    }
}