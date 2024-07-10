﻿using NorthWind.BlazingPizza.Backend.BusinessObject.Interfaces.GetOrder;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetOrderRepository(IGetOrderDataSource dataSource) :
        IGetOrderRepository
    {
        public async Task<GetOrderOrderDto> GetOrderAsync(int id) =>
           await dataSource.GetOrderByIdAsync(id);
    }
}
