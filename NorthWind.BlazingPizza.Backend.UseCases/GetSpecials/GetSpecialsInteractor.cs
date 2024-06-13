using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetSpecials
{
    public class GetSpecialsInteractor(IGetSpecialsRepository repository,
        IGetSpecialsOutputPort presenter) : IGetSpecialsInputPort
    {
        public async Task GetSpecialsAsync()
        {
            var Specials = await repository
                .GetSpecialsSortedByDescendingPriceAsync();

            await presenter.HandleResultAsync(Specials);
        }
    }
}
