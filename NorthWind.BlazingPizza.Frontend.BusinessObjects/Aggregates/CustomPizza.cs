using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Aggregates
{
    public class CustomPizza
    {
        private readonly List<ToppingDto> ToppingsField = [];

        public CustomPizza(PizzaSpecialDto special,
            BlazingPizzaOptions options)
        {
            Special = special;
            Options = options;
            Size = Options.DefaultPizzaSize;
        }

        public PizzaSpecialDto Special { get; }
        public BlazingPizzaOptions Options { get; }
        public int Size { get; set; }

        public IEnumerable<ToppingDto> Toppings => ToppingsField;
        public bool HasMaximumToppings => ToppingsField.Count >= Options.MaximumCustomPizzaToppings;

        public void AddToppings(ToppingDto topping)
        {
            if (!ToppingsField.Contains(topping))
            {
                ToppingsField.Add(topping);
            }
        }

        public void RemoveTopping(ToppingDto topping) =>
            ToppingsField.Remove(topping);

        public decimal GetBasePrice() =>
            (decimal)Size / Options.DefaultPizzaSize * Special.BasePrice;

        public decimal GetTotalPrice() =>
            GetBasePrice() + ToppingsField.Sum(t => t.Price);

        public string GetFormattedTotalPrice() =>
            GetTotalPrice().ToString($"0.00");

        public string GetFormattedSizeWithTotalPrice() =>
            $"{Size} cm ({GetFormattedTotalPrice()})";
    }
}
