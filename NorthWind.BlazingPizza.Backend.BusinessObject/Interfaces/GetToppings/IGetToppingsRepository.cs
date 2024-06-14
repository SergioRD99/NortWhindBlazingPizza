using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings
{
    public interface IGetToppingsRepository
    {
        Task<IEnumerable<ToppingDto>> GetToppingsSortedByNameAscending();
    }
}
