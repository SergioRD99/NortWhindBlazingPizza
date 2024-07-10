using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrder;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetOrder
{
    internal class GetOrderInteractor(
        IGetOrderRepository repository) : IGetOrderInputPort
    {
        public Task<GetOrderOrderDto> GetOrderAsync(int id) => 
            repository.GetOrderAsync(id);
    }
}
