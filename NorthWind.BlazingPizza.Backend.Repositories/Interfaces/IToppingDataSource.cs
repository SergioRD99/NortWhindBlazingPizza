using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IToppingDataSource
    {
        Task<IEnumerable<ToppingDto>> GetToppingDtosFromQueryAsync(
            Func<IQueryable<Topping>, IQueryable<ToppingDto>> queryBuilder);
    }
}
