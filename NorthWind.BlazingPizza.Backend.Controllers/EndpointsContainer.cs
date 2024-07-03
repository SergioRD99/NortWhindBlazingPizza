using NorthWind.BlazingPizza.Backend.Controllers.GetOrders;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;
using NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder;

namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazzingPizzaControllers(
            this WebApplication app)
        {
            app.UseGetSpecialsController();
            app.UseGetToppingsController();
            app.UsePlaceOrderController();
            app.UsegetOrdersControllers();

            return app;
        }
    }
}
