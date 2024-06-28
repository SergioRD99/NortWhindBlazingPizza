using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContexts;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class PlaceOrderDataSource(
        IOptions<DBOptions> options):
        BlazingPizzaContext(options),
        IplaceOrderDataSource
    {
        public async Task PlaceOrderAsyn(Order order)
        {
            Orders.Add(order);
            await SaveChangesAsync();
        }
    }
}
