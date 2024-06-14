using System.Net.Http.Json;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObject;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings
{
    internal class GetToppingsModel(HttpClient client):
        IGetToppingsModel
    {
         IEnumerable<ToppingDto> Toppings;
        public async Task<IEnumerable<ToppingDto>> GetToppingsAsync()
        {
            if (Toppings == null)
            {
                Toppings = await client
                    .GetFromJsonAsync<IEnumerable<ToppingDto>>(
                        Endpoints.GetToppings);
            }

            return Toppings;
        }
    }
}
