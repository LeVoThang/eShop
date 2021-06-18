using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLengthType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"),
                column: "ConcurrencyStamp",
                value: "1fb66c9d-900b-4a0d-83a3-b76940143ff5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d03e99b5-052c-48f1-89e6-b8c3e654c7fe", "AQAAAAEAACcQAAAAEJNe39YEiftMH6KMI2Akf7Y+qsEg7AF2ze4tZs/b9QJuyNRiE2FcNAEiDXHy1FGaPw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 17, 15, 45, 21, 915, DateTimeKind.Local).AddTicks(9354));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"),
                column: "ConcurrencyStamp",
                value: "50e2d087-a17a-4a8c-b402-b4602186b8a1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9c91ae8-7a46-4dbe-8c06-401725586f3c", "AQAAAAEAACcQAAAAEF6n57ZsF4mbJmjhDQSRUJkaf5MJaA3gfGd2/+k8uWyVN3ShGSRFXaZavJsRyifbgg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 17, 15, 30, 48, 431, DateTimeKind.Local).AddTicks(6726));
        }
    }
}
