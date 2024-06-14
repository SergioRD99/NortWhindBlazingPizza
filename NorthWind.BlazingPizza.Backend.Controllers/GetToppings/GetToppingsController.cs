using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetToppings
{
    public static class GetToppingsController
    {
        public static WebApplication UseGetToppingsController(
            this WebApplication app)
        {
            app.MapGet(Endpoints.GetToppings,
                async (IGetToppingsInputPort inputPort) =>
                    TypedResults.Ok(await inputPort.GetToppingsAsync()));
            return app;
        }

    }
}
