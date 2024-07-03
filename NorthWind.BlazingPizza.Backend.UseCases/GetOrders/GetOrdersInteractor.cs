using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetOrders
{
    internal class GetOrdersInteractor(IGetOrdersRepository repository):IGetOrdersInputPort
    {
        public Task<IEnumerable<GetOrdersDto>> GetOrdersAsync() 
            => repository.GetOrderSortedByDescendingIdAsync();

    }
}
