namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials
{
    public interface IGetSpecialsModels
    {
        Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync();
    }
}
