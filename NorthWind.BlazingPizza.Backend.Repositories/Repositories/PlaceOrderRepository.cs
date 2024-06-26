using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Extensions;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Enums;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class PlaceOrderRepository(
        IplaceOrderDataSource dataSource) : IPlaceOrderRepository
    {
        public async Task<int> PlaceorderAsync(PlaceOrderOrderDto order)
        {
            var Order = new Order();
            Order.CreatedTIme = DateTime.Now;
            Order.Status = OrderStatus.Preparing;
            Order.Pizzas = order.Pizzas
                .Select(p => p.ToCustomPizza()).ToList();

            await dataSource.PlaceOrderAsyn(Order);
            return Order.Id;
        }
    }
}
