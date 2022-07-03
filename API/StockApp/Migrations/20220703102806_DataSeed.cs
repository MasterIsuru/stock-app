using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockApp.API.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 28, 6, 30, DateTimeKind.Utc).AddTicks(3810));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "PriceSources_Tickers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 3, 10, 27, 58, 480, DateTimeKind.Utc).AddTicks(7599));
        }
    }
}
