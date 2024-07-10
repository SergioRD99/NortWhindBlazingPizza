namespace NorthWind.BlazingPizza.Entities.ValueObject
{
    public class Endpoints
    {
        public const string GetSpecials = $"/{nameof(GetSpecials)}";
        public const string GetToppings = $"/{nameof(GetToppings)}";
        public const string PlaceOrder = $"/{nameof(PlaceOrder)}";
        public const string GetOrders = $"/{nameof(GetOrders)}";
        public const string GetOrder = $"/{nameof(GetOrder)}";
    }
}
