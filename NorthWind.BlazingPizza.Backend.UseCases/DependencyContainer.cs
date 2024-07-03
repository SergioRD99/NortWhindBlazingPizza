using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.UseCases.GetOrders;
using NorthWind.BlazingPizza.Backend.UseCases.GetToppings;
using NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();

            services.AddScoped<IGetToppingsInputPort, GetToppingsInteractor>();

            services.AddScoped<IPlaceOrderInputPort, PlaceOrderInteractor>();

            services.AddScoped<IGetOrdersInputPort, GetOrdersInteractor>();

            return services;
        }
        
    }
}
