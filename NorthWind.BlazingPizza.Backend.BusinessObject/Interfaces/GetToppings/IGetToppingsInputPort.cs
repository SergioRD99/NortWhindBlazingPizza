using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings
{
    public interface IGetToppingsInputPort
    {
        Task<IEnumerable<ToppingDto>> GetToppingsAsync();
    }
}
