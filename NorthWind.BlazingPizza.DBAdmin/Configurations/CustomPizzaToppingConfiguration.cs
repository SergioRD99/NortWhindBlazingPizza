using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    public class CustomPizzaToppingConfiguration:
        IEntityTypeConfiguration<CustomPizzaTopping>
    {
        public void Configure(EntityTypeBuilder<CustomPizzaTopping> builder)
        {
            builder.HasKey(cpt =>
                new { cpt.CustomPizzaId, cpt.ToppingId });
            builder.HasOne<CustomPizza>()
                .WithMany(cp => cp.Toppings);
            builder.HasOne(cpt => cpt.Topping)
                .WithMany();
        }
    }
}
