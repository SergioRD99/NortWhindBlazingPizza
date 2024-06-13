using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContexts;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class PizzaSpecialDataSource :
        BlazingPizzaContext,
        IPizzaSpecialsDataSource
    {

        public PizzaSpecialDataSource(IOptions<DBOptions> options): base(options) 
        {
            ChangeTracker.QueryTrackingBehavior =
                QueryTrackingBehavior.NoTracking;
        }

        public async Task<IEnumerable<PizzaSpecialDto>> 
            GetPizzaSpecialDtosFromQueryAsync(Func<IQueryable<PizzaSpecials>, IQueryable<PizzaSpecialDto>> queryBuilder)
        {
            IQueryable<PizzaSpecialDto> Query = queryBuilder(PizzaSpecials);
            return await Query.ToListAsync();
        }
    }
}
