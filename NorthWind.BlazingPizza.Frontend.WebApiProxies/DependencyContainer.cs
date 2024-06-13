namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
    public static class DependencyContainer 
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            Action<HttpClient> configureGetSpecialsModelHttpClient,
            Action<IHttpClientBuilder> getSpecialsHttpClientBuilder)
        {
            //services.AddScoped<IGetSpecialsModels, GetSpecialsModel>();
            IHttpClientBuilder Builder =
                services.AddHttpClient<IGetSpecialsModels,
                    GetSpecialsModel>(configureGetSpecialsModelHttpClient);

            getSpecialsHttpClientBuilder?.Invoke(Builder);
            return services;
        }
    }
}
