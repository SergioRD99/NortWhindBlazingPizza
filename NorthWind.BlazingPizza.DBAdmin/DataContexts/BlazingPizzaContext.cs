using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NorthWind.BlazingPizza.DBAdmin.DataContexts
{
    public class BlazingPizzaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=tcp:lgfm.database.windows.net,1433;Initial Catalog=BlazingPizza;Persist Security Info=False;User ID=AdminLGF;Password=OrionRocky1975;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
          
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PizzaSpecials> PizzaSpecials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
    }
}
