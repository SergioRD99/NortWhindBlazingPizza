using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            Action<HttpClient> configureGetSpecialsModelHttpClient,
            Action<IHttpClientBuilder> getSpecialsHttpClientBuilder,
            Action<HttpClient> configureGetToppingsModelHttpClient,
            Action<IHttpClientBuilder> getToppingsHttpClientBuilder
            )
        {

            //services.AddScoped<IGetSpecialsModels, GetSpecialsModel>();
            IHttpClientBuilder Builder =
                services.AddHttpClient<IGetSpecialsModels,
                    GetSpecialsModel>(configureGetSpecialsModelHttpClient);

            getSpecialsHttpClientBuilder?.Invoke(Builder);

            IHttpClientBuilder GetToppingsBuilder =
                services.AddHttpClient<IGetToppingsModel,
                    GetToppingsModel>(configureGetToppingsModelHttpClient);

            getToppingsHttpClientBuilder?.Invoke(GetToppingsBuilder);
            return services;
        }
    }
}
