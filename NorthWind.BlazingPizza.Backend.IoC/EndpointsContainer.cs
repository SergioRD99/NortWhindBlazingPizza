using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;

namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazingPizzaEndpoints(
            this WebApplication app)
        {
            app.UseGetSpecialsController();
            app.UseGetToppingsController();
            return app;
        }
    }
}
