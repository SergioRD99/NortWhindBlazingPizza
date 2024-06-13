namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetSpecialsRepository(
        IPizzaSpecialsDataSource dataSource) : IGetSpecialsRepository
    {
        public Task<IEnumerable<PizzaSpecialDto>>
            GetSpecialsSortedByDescendingPriceAsync() =>
            dataSource.GetPizzaSpecialDtosFromQueryAsync(
                pizzaSpecials =>
            pizzaSpecials
            .OrderByDescending(s => s.BasePrice)
            .Select(s => new PizzaSpecialDto(
                s.Id,
                s.Name,
                s.BasePrice,
                s.Description,
                s.ImageUrl
                )
            ));

    }
}
