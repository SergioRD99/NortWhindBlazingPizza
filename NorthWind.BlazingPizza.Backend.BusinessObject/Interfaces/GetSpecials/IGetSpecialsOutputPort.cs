using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetSpecials
{
    public interface IGetSpecialsOutputPort
    {
        IEnumerable<PizzaSpecialDto> PizzaSpecials { get; }
        Task HandleResultAsync(IEnumerable<PizzaSpecialDto>  pizzaSpecials);
    }
}
