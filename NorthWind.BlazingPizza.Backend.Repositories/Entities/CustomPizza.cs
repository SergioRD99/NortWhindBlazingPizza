namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    public class CustomPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        public PizzaSpecials PizzaSpecial { get; set; }

        public int PizzaSpecialId { get; set; }
        public int Size { get; set; }
        public List<CustomPizzaTopping> Toppings { get; set; }

        public decimal TotalPrice { get; set; }

    }
}

