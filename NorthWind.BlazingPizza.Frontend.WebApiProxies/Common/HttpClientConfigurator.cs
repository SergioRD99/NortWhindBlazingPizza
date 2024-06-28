namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Common
{
    public class HttpClientConfigurator(
        Action<HttpClient> configureHttpClient,
        Action<IHttpClientBuilder> configureNamedHttpClient = null)
    {
      public Action<HttpClient> ConfigureHttpClient => configureHttpClient;
      public Action<IHttpClientBuilder> ConfigureNamedHttpClient => configureNamedHttpClient;
    }
}
