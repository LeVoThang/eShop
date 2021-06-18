using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"),
                column: "ConcurrencyStamp",
                value: "5543901e-3fa8-4829-ad86-1000f77fdfde");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2e22de5-a7f9-4f7d-9a55-0c74f2a56d2a", "AQAAAAEAACcQAAAAENO+xlddcqRzy+LP1oCcO8+8+93p3eT5TDgSPZbDQ9+sQCH9xgxaWOvcv1VU8EwGKA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 17, 11, 43, 56, 404, DateTimeKind.Local).AddTicks(4301));
        }
    }
}
