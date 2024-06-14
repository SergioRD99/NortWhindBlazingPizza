using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetToppingsRepository(
        IToppingDataSource dataSource): IGetToppingsRepository
    {
        public Task<IEnumerable<ToppingDto>> GetToppingsSortedByNameAscending() =>
            dataSource.GetToppingDtosFromQueryAsync(
                toppings =>
                toppings
                .OrderBy(t => t.Name)
                .Select(t => new ToppingDto(
                    t.Id, t.Name, t.Price)));
    }
}
