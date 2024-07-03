using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection.Interfaces.Orders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using NorthWind.BlazingPizza.Entities.ValueObject;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Orders
{
    internal class OrdersModel(HttpClient client):IOrdersModel
    {
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersAsync()
            => await client.GetFromJsonAsync<IEnumerable<GetOrdersDto>>(
                Endpoints.GetOrders);
    }
}
