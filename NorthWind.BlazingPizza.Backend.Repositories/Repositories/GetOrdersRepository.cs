using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetOrdersRepository(
        IOrdersDataSource dataSource): IGetOrdersRepository
    {
        public Task<IEnumerable<GetOrdersDto>>
            GetOrderSortedByDescendingIdAsync() =>
            dataSource.GetOrdersFromQuery(
                orders => orders.OrderByDescending(o => o.Id)
                    .Select(o => new GetOrdersDto(
                        o.Id,
                        o.CreatedTIme,
                        o.Pizzas.Count,
                        o.Pizzas.Sum(p => p.TotalPrice),
                        o.Status)));

    }
}
