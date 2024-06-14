﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthWind.BlazingPizza.DBAdmin.DataContexts;

#nullable disable

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    [DbContext(typeof(BlazingPizzaContext))]
    [Migration("20240614011843_AddToppings")]
    partial class AddToppings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NorthWind.BlazingPizza.Backend.Repositories.Entities.PizzaSpecials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasePrice")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PizzaSpecials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 89.99m,
                            Description = "Es de queso y delicioso. Â¿Por quÃ© no querrÃ­as una?",
                            ImageUrl = "cheese.jpg",
                            Name = "Pizza clÃ¡sica de queso"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 127.99m,
                            Description = "Tiene TODO tipo de tocino",
                            ImageUrl = "bacon.jpg",
                            Name = "Tocinator"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 99.50m,
                            Description = "Es la pizza con la que creciste, Â¡pero ardientemente deliciosa!",
                            ImageUrl = "pepperoni.jpg",
                            Name = "ClÃ¡sica de pepperoni"
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = 128.75m,
                            Description = "Pollo picante, salsa picante y queso azul, garantizado que entrarÃ¡s en calor",
                            ImageUrl = "meaty.jpg",
                            Name = "Pollo bÃºfalo"
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = 109.00m,
                            Description = "Tiene champiÃ±ones. Â¿No es obvio?",
                            ImageUrl = "mushroom.jpg",
                            Name = "Amantes del champiÃ±Ã³n"
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = 90.25m,
                            Description = "De piÃ±a, jamÃ³n y queso...",
                            ImageUrl = "hawaiian.jpg",
                            Name = "Hawaiana"
                        },
                        new
                        {
                            Id = 7,
                            BasePrice = 118.50m,
                            Description = "Es como una ensalada, pero en una pizza",
                            ImageUrl = "salad.jpg",
                            Name = "Delicia vegetariana"
                        },
                        new
                        {
                            Id = 8,
                            BasePrice = 89.99m,
                            Description = "Pizza italiana tradicional con tomates y albahaca",
                            ImageUrl = "margherita.jpg",
                            Name = "Margarita"
                        });
                });

            modelBuilder.Entity("NorthWind.BlazingPizza.Backend.Repositories.Entities.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Queso extra",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tocino de pavo",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tocino jabali",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tocino ternera",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tao y bollos",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bollos recien horneados",
                            Price = 33.50m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pimiento",
                            Price = 53.50m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cebolla ",
                            Price = 43.50m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Champiñiones",
                            Price = 33.50m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Peperono",
                            Price = 24.50m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Salchicha",
                            Price = 25.50m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Albondigas",
                            Price = 27.50m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Langosta",
                            Price = 33.50m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Caviar",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Alcachofa",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 16,
                            Name = "Tomates",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 17,
                            Name = "Albahaca",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 18,
                            Name = "Filete",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 19,
                            Name = "Pimientos",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 20,
                            Name = "Pollo bufalo",
                            Price = 23.50m
                        },
                        new
                        {
                            Id = 21,
                            Name = "Queso azul",
                            Price = 23.50m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
