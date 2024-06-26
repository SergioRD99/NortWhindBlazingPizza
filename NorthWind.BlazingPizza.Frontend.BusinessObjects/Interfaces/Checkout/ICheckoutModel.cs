using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace Microsoft.Extensions.DependencyInjection.Interfaces.Checkout;

public interface ICheckoutModel
{
    Task<int> PlaceOrderAsync(ShoppingCart orden);

}