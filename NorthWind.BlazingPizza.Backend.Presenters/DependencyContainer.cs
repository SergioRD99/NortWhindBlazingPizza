using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Presenters.GetSpecials;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsOutputPort, GetSpecialsPresenter>();

            return services;
        }
    }

}
