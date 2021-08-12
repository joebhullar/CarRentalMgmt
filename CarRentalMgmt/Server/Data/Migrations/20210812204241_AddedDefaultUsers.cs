using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalMgmt.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c010874-f6ce-43bc-94b9-5e60de45b866");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13011",
                column: "ConcurrencyStamp",
                value: "38ca92f0-ed8d-4266-abdd-5bc72836f515");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13022", "219bed08-b755-4d80-816d-0fb247850013", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13011", "13025" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13022", 0, "21f683a7-2f54-41fd-a1d7-87ab9a31756b", "Admin@localhost.com", false, "System", "Admin", false, null, "Admin@localhost.com", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEE4FCssNNSv2pnBSltheIpXDBpA6YilHTLSEvYQ7bJSwoyhQLiZKGoNC7JmxoXJ5IA==", null, false, "6374880d-40b4-46c1-acf1-a3e153174171", false, "admin@localhost.com" },
                    { "13011", 0, "84cb4d0f-2b40-4eab-818b-f21013ce974b", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEONEVr7YMgspVWMpgKwt5wy6apjVZ9BQ4vYBx4WPhTm3XorXsV1EvmNMbaqd8n1k3g==", null, false, "06be6813-ce68-4999-882f-d8c1cf13f758", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 447, DateTimeKind.Local).AddTicks(3803), new DateTime(2021, 8, 12, 14, 42, 41, 450, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 450, DateTimeKind.Local).AddTicks(6350), new DateTime(2021, 8, 12, 14, 42, 41, 450, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(7787), new DateTime(2021, 8, 12, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(8167), new DateTime(2021, 8, 12, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1300), new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1675), new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1685), new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1689), new DateTime(2021, 8, 12, 14, 42, 41, 452, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13022", "13023" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13022", "13023" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13011", "13025" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13022");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13022");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13011",
                column: "ConcurrencyStamp",
                value: "426b8afd-154a-43f5-b215-a550777f4476");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c010874-f6ce-43bc-94b9-5e60de45b866", "67739a8e-b04c-4d18-b8a6-e6309f7e8d77", "User", "USER" });

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
    }
}
