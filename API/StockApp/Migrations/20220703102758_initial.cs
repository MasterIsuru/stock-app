using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockApp.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceSources_Tickers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TickerId = table.Column<int>(type: "int", nullable: false),
                    PriceSourceId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSources_Tickers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PriceSources",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Source 1", "SRC1" },
                    { 2, "Source 2", "SRC2" },
                    { 3, "Source 3", "SRC3" },
                    { 4, "Source 4", "SRC4" },
                    { 5, "Source 5", "SRC5" },
                    { 6, "Source 6", "SRC6" }
                });

            migrationBuilder.InsertData(
                table: "PriceSources_Tickers",
                columns: new[] { "Id", "CreatedAt", "Price", "PriceSourceId", "TickerId" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7599), 109.25f, 1, 1 },
                    { 5, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7597), 90.54f, 1, 1 },
                    { 4, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7596), 110.44f, 1, 1 },
                    { 3, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7595), 92.11f, 1, 1 },
                    { 2, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7593), 103.44f, 1, 1 },
                    { 1, new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7323), 100.44f, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tickers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "IBM", "IBM UN" },
                    { 2, "INTEL", "ITL SE" },
                    { 3, "SAMSUNG", "SMG CC" },
                    { 4, "APPLE", "APL US" },
                    { 5, "FACEBOOK", "FBK EE" },
                    { 6, "TESLA", "TLA RR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceSources");

            migrationBuilder.DropTable(
                name: "PriceSources_Tickers");

            migrationBuilder.DropTable(
                name: "Tickers");
        }
    }
}
