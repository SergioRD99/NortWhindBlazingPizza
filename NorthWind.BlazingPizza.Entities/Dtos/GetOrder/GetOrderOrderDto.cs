using NorthWind.BlazingPizza.Entities.Enums;

namespace NorthWind.BlazingPizza.Entities.Dtos.GetOrder
{
    public class GetOrderOrderDto(int id, DateTime createdTime, IEnumerable<GetOrderPizzaDto> pizzas, OrderStatus status)
    {
        public int Id => id;
        public DateTime CreatedTime => createdTime;
        public IEnumerable<GetOrderPizzaDto> Pizzas => pizzas;
        public OrderStatus Status => status;
        public decimal GetTotalPrice()=>
            pizzas.Sum(p => p.TotalPrice);
        public string GetFormattedTotalPrice() =>
            GetTotalPrice().ToString("$ #,###.00");

    }
}
