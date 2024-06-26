using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;

public interface IPlaceOrderInputPort
{
    Task<int> PlaceorderAsync(PlaceOrderOrderDto order);
}