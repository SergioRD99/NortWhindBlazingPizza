using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories
            (this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();

            services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();

            services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();

            services.AddScoped<IGetOrdersRepository, GetOrdersRepository>();

            return services;
        }
    }
}
