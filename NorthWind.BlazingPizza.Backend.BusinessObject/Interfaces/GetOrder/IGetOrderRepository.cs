using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrder
{
    public interface IGetOrderRepository
    {
        Task<GetOrderOrderDto> GetOrderAsync(int id);
    }
}
