using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetOrders
{
    internal static class GetOrdersController
    {
        public static WebApplication UsegetOrdersControllers(
            this WebApplication app)
        {
            app.MapGet(Endpoints.GetOrders,
                async (IGetOrdersInputPort inputPort) =>
                    TypedResults.Ok(await inputPort.GetOrdersAsync()));

            return app;
        }
    }
}
