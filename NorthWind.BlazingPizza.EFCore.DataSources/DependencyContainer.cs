using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDataSources(
            this IServiceCollection services,
            Action<DBOptions> configureDBOption)
        {

            services.AddScoped<IPizzaSpecialsDataSource, PizzaSpecialDataSource>();
            services.AddScoped<IToppingDataSource, ToppingDataSource>();
            services.AddScoped<IplaceOrderDataSource, PlaceOrderDataSource>();

            services.Configure(configureDBOption);

            return services;
        }
    }

}
