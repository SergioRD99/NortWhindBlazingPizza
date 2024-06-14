using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    internal class ToppingConfiguration : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            builder.Property(t => t.Price)
                .HasPrecision(8, 2);

            builder.HasData(
                new Topping { Id=1, Name="Queso extra", Price=23.50m},
                new Topping { Id = 2, Name = "Tocino de pavo", Price = 23.50m },
                new Topping { Id = 3, Name = "Tocino jabali", Price = 23.50m },
                new Topping { Id = 4, Name = "Tocino ternera", Price = 23.50m },
                new Topping { Id = 5, Name = "Tao y bollos", Price = 23.50m },
                new Topping { Id = 6, Name = "Bollos recien horneados", Price = 33.50m },
                new Topping { Id = 7, Name = "Pimiento", Price = 53.50m },
                new Topping { Id = 8, Name = "Cebolla ", Price = 43.50m },
                new Topping { Id = 9, Name = "Champiñiones", Price = 33.50m },
                new Topping { Id = 10, Name = "Peperono", Price = 24.50m },
                new Topping { Id = 11, Name = "Salchicha", Price = 25.50m },
                new Topping { Id = 12, Name = "Albondigas", Price = 27.50m },
                new Topping { Id = 13, Name = "Langosta", Price = 33.50m },
                new Topping { Id = 14, Name = "Caviar", Price = 23.50m },
                new Topping { Id = 15, Name = "Alcachofa", Price = 23.50m },
                new Topping { Id = 16, Name = "Tomates", Price = 23.50m },
                new Topping { Id = 17, Name = "Albahaca", Price = 23.50m },
                new Topping { Id = 18, Name = "Filete", Price = 23.50m },
                new Topping { Id = 19, Name = "Pimientos", Price = 23.50m },
                new Topping { Id = 20, Name = "Pollo bufalo", Price = 23.50m },
                new Topping { Id = 21, Name = "Queso azul", Price = 23.50m }
                );
        }
    }
}
