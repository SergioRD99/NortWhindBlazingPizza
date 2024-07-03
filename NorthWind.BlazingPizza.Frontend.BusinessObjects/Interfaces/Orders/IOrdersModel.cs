using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace Microsoft.Extensions.DependencyInjection.Interfaces.Orders;

public interface IOrdersModel
{
    Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
}