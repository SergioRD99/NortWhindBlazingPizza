using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;

namespace NorthWind.BlazingPizza.Backend.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories
            (this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();

            services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();

            return services;
        }
    }
}
