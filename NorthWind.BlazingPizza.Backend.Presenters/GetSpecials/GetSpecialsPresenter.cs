using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinessObject.Option;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Presenters.GetSpecials
{
    internal class GetSpecialsPresenter(
        IOptions<BlazzingPizzaOption> options)
        : IGetSpecialsOutputPort
    {
        public IEnumerable<PizzaSpecialDto> PizzaSpecials { get; private set; }

        public Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials)
        {
            PizzaSpecials = pizzaSpecials
             .Select(s => new PizzaSpecialDto(
                    s.Id, s.Name, s.BasePrice, s.Description,
                    $"{options.Value.ImageUrlBase}/{s.ImageUrl}"));

            return Task.CompletedTask;
        }
    }
}
