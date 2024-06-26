using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces;

public interface IplaceOrderDataSource
{
    Task PlaceOrderAsyn(Order  order);
}