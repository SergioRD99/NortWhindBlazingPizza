using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;

namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazingPizzaEndpoints(
            this WebApplication app)
        {
            app.UseGetSpecialsController();

            return app;
        }
    }
}
