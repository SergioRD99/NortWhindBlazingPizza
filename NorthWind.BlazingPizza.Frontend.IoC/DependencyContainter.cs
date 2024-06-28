using System.Transactions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Common;

namespace NorthWind.BlazingPizza.Frontend.IoC
{
    public static class DependencyContainter
    {
        public static IServiceCollection AddBlazingPizzaServices(
            this IServiceCollection services,
            Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
        {
            BlazingPizzaOptions BlazingPizzaOptions = new();
            configureBlazingPizzaOptions(BlazingPizzaOptions);



            services.AddModels(BlazingPizzaOptions);
                
            services.AddViewModels();

            services.AddSingleton(Options.Create(BlazingPizzaOptions));

            services.AddBusinessObjectServices();
            return services;
        }

        static IServiceCollection AddModels(this IServiceCollection services,
            BlazingPizzaOptions options)
        {
            Uri WebApiUri = new Uri(options.WebApiBaseAddress);
            var Configurator = new HttpClientConfigurator(
                httpClient => httpClient.BaseAddress = WebApiUri,
                null);

            services.AddModels(Configurator, Configurator, Configurator);
            return services;
        }
    }
}
