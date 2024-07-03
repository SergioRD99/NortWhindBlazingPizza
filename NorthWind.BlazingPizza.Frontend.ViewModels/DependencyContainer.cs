using NorthWind.BlazingPizza.Frontend.ViewModels.Checkout;
using NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;
using NorthWind.BlazingPizza.Frontend.ViewModels.Index;
using NorthWind.BlazingPizza.Frontend.ViewModels.Orders;

namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddViewModels(
            this IServiceCollection serivce)
        {
            serivce.AddScoped<GetSpecialsViewModel>();
            serivce.AddScoped<ConfigurePizzaDialogViewModel>();
            serivce.AddScoped<IndexViewModel>();
            serivce.AddScoped<CheckoutViewModel>();
            serivce.AddScoped<OrdersViewModel>();
            return serivce;
        }
    }
}
