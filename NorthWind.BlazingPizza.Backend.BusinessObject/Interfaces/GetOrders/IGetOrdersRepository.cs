using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;

public interface IGetOrdersRepository
{
    Task<IEnumerable<GetOrdersDto>> GetOrderSortedByDescendingIdAsync();
}