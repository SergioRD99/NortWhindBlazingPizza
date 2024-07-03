using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IOrdersDataSource
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersFromQuery(
            Func<IQueryable<Order>, IQueryable<GetOrdersDto>> queryBuilder);
    }
}
