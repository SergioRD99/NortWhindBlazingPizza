namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazingPizzaEndpoints(
            this WebApplication app)
        {
            app.UseBlazzingPizzaControllers();
            return app;
        }
    }
}
