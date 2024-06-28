using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;

public interface IGetOrdersInputPort
{
    Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
}