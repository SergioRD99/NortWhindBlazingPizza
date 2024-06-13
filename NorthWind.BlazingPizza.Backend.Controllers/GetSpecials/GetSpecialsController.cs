namespace NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;

public static class GetSpecialsController
{
    public static WebApplication UseGetSpecialsController(
        this WebApplication app)
    {
        app.MapGet(Endpoints.GetSpecials,
            async (IGetSpecialsInputPort inputPort,
                IGetSpecialsOutputPort presenter) =>
            {
                //¿Que hacer?
                await inputPort.GetSpecialsAsync();
                return TypedResults.Ok(presenter.PizzaSpecials);
            });

        return app;
    }
}

