using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.DBAdmin.Configurations;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataContexts
{
    internal class BlazingPizzaContext(IOptions<DBOptions> options):
        DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(options.Value.ConnectionString);
           
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(PizzaSpecialConfiguration).Assembly );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PizzaSpecials> PizzaSpecials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
    }
}
