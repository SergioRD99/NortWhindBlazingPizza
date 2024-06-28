using Microsoft.Extensions.DependencyInjection.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Checkout;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Common;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            HttpClientConfigurator getSpecialsModelConfigurator,
            HttpClientConfigurator getToppingsModelConfigurator,
            HttpClientConfigurator checkoutModelConfigurator
            )
        {

            services.AddHttpClient<IGetSpecialsModels, GetSpecialsModel>(getSpecialsModelConfigurator);
            services.AddHttpClient<IGetToppingsModel, GetToppingsModel>(getToppingsModelConfigurator);
            services.AddHttpClient<ICheckoutModel, CheckoutModel>(checkoutModelConfigurator);
            return services;
        }

        static IServiceCollection AddHttpClient<TClient, TImplementation>(
            this IServiceCollection service,
            HttpClientConfigurator configurator)
        where TClient : class where TImplementation : class, TClient
        {
            var Builder = service.AddHttpClient<TClient, TImplementation>(
                configurator.ConfigureHttpClient);

            configurator.ConfigureNamedHttpClient?.Invoke(Builder);

            return service;
        }
    }
}
