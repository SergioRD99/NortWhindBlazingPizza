namespace NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials
{
    public class GetSpecialsViewModel(IGetSpecialsModels model)
    {
        public IEnumerable<PizzaSpecialDto> Specials { get; private set; }

        public async Task GetSpecialsAsync()
        {
            Specials = await model.GetSpecialsAsync();
        }
    }
}
