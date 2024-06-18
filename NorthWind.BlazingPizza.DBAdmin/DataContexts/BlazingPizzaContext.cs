using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.DataContexts
{
    public class BlazingPizzaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=BlazingPizza;");
          
            
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
