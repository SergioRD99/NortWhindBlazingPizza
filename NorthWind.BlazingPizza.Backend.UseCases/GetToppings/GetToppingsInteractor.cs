using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetToppings
{
    public class GetToppingsInteractor(
        IGetToppingsRepository repository) : IGetToppingsInputPort
    {
        public Task<IEnumerable<ToppingDto>> GetToppingsAsync() =>
            repository.GetToppingsSortedByNameAscending();
    }
}
