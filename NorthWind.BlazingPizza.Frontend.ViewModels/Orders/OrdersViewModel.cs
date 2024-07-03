using Microsoft.Extensions.DependencyInjection.Interfaces.Orders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Orders
{
    public class OrdersViewModel(IOrdersModel model)
    {
        public IEnumerable<GetOrdersDto> Orders { get; private set; }

        public async Task GetOrderAsnc() =>
            Orders = await model.GetOrdersAsync();
    }
}
