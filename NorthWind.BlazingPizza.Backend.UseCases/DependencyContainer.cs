namespace NorthWind.BlazingPizza.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();

            return services;
        }
        
    }
}
