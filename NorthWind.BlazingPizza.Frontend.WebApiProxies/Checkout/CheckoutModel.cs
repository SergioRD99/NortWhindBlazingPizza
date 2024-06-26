using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Checkout
{
    internal class CheckoutModel : ICheckoutModel
    {
        public async Task<int> PlaceOrderAsync(ShoppingCart orden)
        {
            return await Task.FromResult(0);
        }
    }
}
