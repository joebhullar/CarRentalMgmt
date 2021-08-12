using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalMgmt.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 12, 13, 49, 58, 662, DateTimeKind.Local).AddTicks(1500), new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(7073), "Black", "System" },
                    { 2, "System", new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(8147), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(7898), new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(7912), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(8274), new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(8281), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1272), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1285), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1694), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1702), "BMW", "System" },
                    { 3, "System", new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1705), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1707), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1709), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1711), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
