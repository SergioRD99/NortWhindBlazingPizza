using System.Net.Http.Json;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Entities.ValueObject;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;

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
