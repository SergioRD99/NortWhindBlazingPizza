using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaSpecials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSpecials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PizzaSpecials",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 89.99m, "Es de queso y delicioso. Â¿Por quÃ© no querrÃ­as una?", "cheese.jpg", "Pizza clÃ¡sica de queso" },
                    { 2, 127.99m, "Tiene TODO tipo de tocino", "bacon.jpg", "Tocinator" },
                    { 3, 99.50m, "Es la pizza con la que creciste, Â¡pero ardientemente deliciosa!", "pepperoni.jpg", "ClÃ¡sica de pepperoni" },
                    { 4, 128.75m, "Pollo picante, salsa picante y queso azul, garantizado que entrarÃ¡s en calor", "meaty.jpg", "Pollo bÃºfalo" },
                    { 5, 109.00m, "Tiene champiÃ±ones. Â¿No es obvio?", "mushroom.jpg", "Amantes del champiÃ±Ã³n" },
                    { 6, 90.25m, "De piÃ±a, jamÃ³n y queso...", "hawaiian.jpg", "Hawaiana" },
                    { 7, 118.50m, "Es como una ensalada, pero en una pizza", "salad.jpg", "Delicia vegetariana" },
                    { 8, 89.99m, "Pizza italiana tradicional con tomates y albahaca", "margherita.jpg", "Margarita" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Queso extra", 23.50m },
                    { 2, "Tocino de pavo", 23.50m },
                    { 3, "Tocino jabali", 23.50m },
                    { 4, "Tocino ternera", 23.50m },
                    { 5, "Tao y bollos", 23.50m },
                    { 6, "Bollos recien horneados", 33.50m },
                    { 7, "Pimiento", 53.50m },
                    { 8, "Cebolla ", 43.50m },
                    { 9, "Champiñiones", 33.50m },
                    { 10, "Peperono", 24.50m },
                    { 11, "Salchicha", 25.50m },
                    { 12, "Albondigas", 27.50m },
                    { 13, "Langosta", 33.50m },
                    { 14, "Caviar", 23.50m },
                    { 15, "Alcachofa", 23.50m },
                    { 16, "Tomates", 23.50m },
                    { 17, "Albahaca", 23.50m },
                    { 18, "Filete", 23.50m },
                    { 19, "Pimientos", 23.50m },
                    { 20, "Pollo bufalo", 23.50m },
                    { 21, "Queso azul", 23.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaSpecials");

            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
