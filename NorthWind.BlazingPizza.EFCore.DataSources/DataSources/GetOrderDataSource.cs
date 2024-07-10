using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.BusinessObject.Option;
using NorthWind.BlazingPizza.Backend.Repositories.Extensions;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContexts;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;
using System.Diagnostics;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class GetOrderDataSource :
        BlazingPizzaContext,
        IGetOrderDataSource
    {
        public GetOrderDataSource(IOptions<DBOptions> options) : base(options) 
        {
            ChangeTracker.QueryTrackingBehavior =
                QueryTrackingBehavior.NoTracking;
        }
        public async Task<GetOrderOrderDto> GetOrderByIdAsync(int orderId)
        {
            var Query = Orders
                .Include(o => o.Pizzas).ThenInclude(p => p.PizzaSpecial)
                .Include(o => o.Pizzas).ThenInclude(p => p.Toppings)
                    .ThenInclude(t => t.Topping)
                .Where(o => o.Id == orderId)
                .Select(o => new GetOrderOrderDto(
                    o.Id,
                    o.CreatedTIme,
                    o.Pizzas.Select(p => p.ToGetOrderPizzaDto()),
                    o.Status));
            Debug.WriteLine(Query.ToQueryString());

            var Result = await Query.FirstOrDefaultAsync();

            return Result == null? new GetOrderOrderDto(0,
                DateTime.MinValue, [], Entities.Enums.OrderStatus.Preparing):
                Result;
       
        }
    }
}
