namespace NorthWind.BlazingPizza.Entities.Dtos.GetSpecials
{
    public class PizzaSpecialDto(int id, string name, decimal basePrice, 
        string description, string imageUrl)
    {
        public int Id => id;
        public string Name => name;
        public decimal BasePrice => basePrice;
        public string Description => description;
        public string ImageUrl => imageUrl;
        public string FormattedBasedPrice => basePrice.ToString("0.00");
    }
}
