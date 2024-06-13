using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;

namespace NorthWind.BlazingPizza.Frontend.IoC
{
    public static class DependencyContainter
    {
        public static IServiceCollection AddBlazingPizzaServices(
            this IServiceCollection services,
            Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
        {
            BlazingPizzaOptions blazingPizzaOptions = new();
            configureBlazingPizzaOptions(blazingPizzaOptions);
            services.AddModels(
                httpClient => httpClient.BaseAddress = 
                    new Uri(blazingPizzaOptions.WebApiBaseAddress),
                null);
            services.AddViewModels();

            services.AddSingleton(Options.Create(blazingPizzaOptions));
            return services;
        }
    }
}
