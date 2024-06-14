using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings
{
    public interface IGetToppingsModel
    {
        Task<IEnumerable<ToppingDto>> GetToppingsAsync();
    }
}
