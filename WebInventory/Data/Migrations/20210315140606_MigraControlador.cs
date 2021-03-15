using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebInventory.Data.Migrations
{
    public partial class MigraControlador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id_Category = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id_Category);
                });

            migrationBuilder.CreateTable(
                name: "Deposit",
                columns: table => new
                {
                    Id_Deposito = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(maxLength: 150, nullable: false),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => x.Id_Deposito);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id_Inventory = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Id_Deposito = table.Column<int>(nullable: false),
                    Id_Product = table.Column<int>(nullable: false),
                    Units = table.Column<int>(nullable: false),
                    Unit_Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id_Inventory);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id_Product = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    Id_Category = table.Column<int>(nullable: false),
                    Id_Type = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id_Product);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id_Type = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id_Type);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
