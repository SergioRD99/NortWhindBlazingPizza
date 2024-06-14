
using System.Net.Http.Json;
using NorthWind.BlazingPizza.Entities.ValueObject;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials
{
    internal class GetSpecialsModel (HttpClient client) : IGetSpecialsModels
    {
        IEnumerable<PizzaSpecialDto> Specials;

        public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync()
        {
            if (Specials == null)
            {
                Specials = await client
                    .GetFromJsonAsync<IEnumerable<PizzaSpecialDto>>(
                        Endpoints.GetSpecials);
            }
            return Specials;
        }

    }
}
