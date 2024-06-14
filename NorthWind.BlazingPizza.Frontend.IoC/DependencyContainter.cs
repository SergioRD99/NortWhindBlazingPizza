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
            BlazingPizzaOptions BlazingPizzaOptions = new();
            configureBlazingPizzaOptions(BlazingPizzaOptions);



            Uri WebApiUri = new Uri(BlazingPizzaOptions.WebApiBaseAddress);
            services.AddModels(
                httpClient => httpClient.BaseAddress = WebApiUri,
                null,
                httpCLient => httpCLient.BaseAddress = WebApiUri,
                null
                );
            services.AddViewModels();

            services.AddSingleton(Options.Create(BlazingPizzaOptions));
            return services;
        }
    }
}
