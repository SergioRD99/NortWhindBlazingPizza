using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder
{
    public class PlaceOrderInteractor(
        IPlaceOrderRepository repository) : IPlaceOrderInputPort
    {
        public async Task<int> PlaceorderAsync(PlaceOrderOrderDto order) =>
            await repository.PlaceorderAsync(order);
    }
}
