using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection.Interfaces.Checkout;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObject;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Checkout
{
    internal class CheckoutModel(HttpClient client) : ICheckoutModel
    {
        public async Task<int> PlaceOrderAsync(ShoppingCart orden)
        {
            int OrderId = 0;
            var Response = await client.PostAsJsonAsync(Endpoints.PlaceOrder,
                (PlaceOrderOrderDto)orden);
            if (Response.IsSuccessStatusCode)
            {
                OrderId = await Response.Content.ReadFromJsonAsync<int>();
            }

            return OrderId;
        }
    }
}
