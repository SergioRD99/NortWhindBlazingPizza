using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder;

internal static class PlaceOrderController
{
    public static WebApplication UsePlaceOrderController(
        this WebApplication app)
    {
        app.MapPost(Endpoints.PlaceOrder,
            async (IPlaceOrderInputPort inputPort,
                PlaceOrderOrderDto order) =>
                TypedResults.Ok(await inputPort.PlaceorderAsync(order)));

        return app;
    }
    
}