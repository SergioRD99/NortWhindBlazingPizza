using NorthWind.BlazingPizza.Backend.BusinessObject.Option;
using NorthWind.BlazingPizza.Backend.Repositories;
using NorthWind.BlazingPizza.Backend.UseCases;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBlazingPizzaServices(
            this IServiceCollection services,
            Action<DBOptions> configureDbOptions,
            Action<BlazzingPizzaOption> configureBlazingPizzaOptions)
        {

            services.AddUseCaseServices()
                .AddRepositories()
                .AddDataSources(configureDbOptions)
                .AddPresenters();

            services.Configure(configureBlazingPizzaOptions);
            return services;
        }
    }

}
