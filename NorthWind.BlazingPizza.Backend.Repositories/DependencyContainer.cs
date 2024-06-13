namespace NorthWind.BlazingPizza.Backend.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories
            (this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();

            return services;
        }
    }
}
