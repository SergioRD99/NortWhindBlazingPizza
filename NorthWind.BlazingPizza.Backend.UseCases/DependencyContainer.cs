using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.UseCases.GetToppings;

namespace NorthWind.BlazingPizza.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();

            services.AddScoped<IGetToppingsInputPort, GetToppingsInteractor>();

            return services;
        }
        
    }
}
