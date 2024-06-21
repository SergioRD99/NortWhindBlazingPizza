using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBusinessObjectServices(this IServiceCollection services)
        {
            services.AddScoped<ShoppingCart>();

            return services;
        }
    }

}
