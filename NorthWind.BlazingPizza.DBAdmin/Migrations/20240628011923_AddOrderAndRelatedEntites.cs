using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderAndRelatedEntites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTIme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomPizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PizzaSpecialId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_PizzaSpecials_PizzaSpecialId",
                        column: x => x.PizzaSpecialId,
                        principalTable: "PizzaSpecials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomPizzaTopping",
                columns: table => new
                {
                    CustomPizzaId = table.Column<int>(type: "int", nullable: false),
                    ToppingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzaTopping", x => new { x.CustomPizzaId, x.ToppingId });
                    table.ForeignKey(
                        name: "FK_CustomPizzaTopping_CustomPizzas_CustomPizzaId",
                        column: x => x.CustomPizzaId,
                        principalTable: "CustomPizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomPizzaTopping_Toppings_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "Toppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_OrderId",
                table: "CustomPizzas",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_PizzaSpecialId",
                table: "CustomPizzas",
                column: "PizzaSpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzaTopping_ToppingId",
                table: "CustomPizzaTopping",
                column: "ToppingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomPizzaTopping");

            migrationBuilder.DropTable(
                name: "CustomPizzas");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
