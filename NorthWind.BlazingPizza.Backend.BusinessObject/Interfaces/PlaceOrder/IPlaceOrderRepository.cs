using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;

public interface IPlaceOrderRepository
{
    Task<int> PlaceorderAsync(PlaceOrderOrderDto order);
}