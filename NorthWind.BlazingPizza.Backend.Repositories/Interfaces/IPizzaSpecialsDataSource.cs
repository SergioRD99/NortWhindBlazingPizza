using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IPizzaSpecialsDataSource
    {
        Task<IEnumerable<PizzaSpecialDto>> GetPizzaSpecialDtosFromQueryAsync(
            Func<IQueryable<PizzaSpecials>,
                IQueryable<PizzaSpecialDto>> queryBuilder);
    }
}
