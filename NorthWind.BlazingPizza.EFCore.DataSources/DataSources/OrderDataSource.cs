using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContexts;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class OrderDataSource :
        BlazingPizzaContext,
        IOrdersDataSource
    {
        public OrderDataSource(IOptions<DBOptions> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior =
                QueryTrackingBehavior.NoTracking;
        }
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersFromQuery
            (Func<IQueryable<Order>, IQueryable<GetOrdersDto>> queryBuilder)
        {
            var QueryableOrders = Orders
                .Include(o => o.Pizzas);
            return await queryBuilder(QueryableOrders).ToListAsync();
        }
    }
}
