using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalMgmt.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c010874-f6ce-43bc-94b9-5e60de45b866", "67739a8e-b04c-4d18-b8a6-e6309f7e8d77", "User", "USER" },
                    { "13011", "426b8afd-154a-43f5-b215-a550777f4476", "Adminsitrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 210, DateTimeKind.Local).AddTicks(2337), new DateTime(2021, 8, 12, 14, 9, 18, 212, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 213, DateTimeKind.Local).AddTicks(1300), new DateTime(2021, 8, 12, 14, 9, 18, 213, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(2140), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(2521), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(5894), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6444), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6454), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6458), new DateTime(2021, 8, 12, 14, 9, 18, 214, DateTimeKind.Local).AddTicks(6460) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c010874-f6ce-43bc-94b9-5e60de45b866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13011");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 662, DateTimeKind.Local).AddTicks(1500), new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 8, 12, 13, 49, 58, 664, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(7898), new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(8274), new DateTime(2021, 8, 12, 13, 49, 58, 665, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1272), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1694), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1705), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1709), new DateTime(2021, 8, 12, 13, 49, 58, 666, DateTimeKind.Local).AddTicks(1711) });
        }
    }
}
