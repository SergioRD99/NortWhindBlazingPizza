namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddViewModels(
            this IServiceCollection serivce)
        {
            serivce.AddScoped<GetSpecialsViewModel>();

            return serivce;
        }
    }
}
