using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 16, 14, 9, 13, 761, DateTimeKind.Local).AddTicks(4309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 16, 11, 41, 8, 879, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"), "1c599d7e-1c38-47d6-9c0f-7dcffa1f333e", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"), new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"), 0, "524d3ad4-86b2-4736-9d99-81ef05730fdd", new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "levothang.99@gmail.com", true, "Thang", "Vo", false, null, "levothang.99@gmail.com", "admin", "AQAAAAEAACcQAAAAEOyMjY9qUnJdVDVdyPNUZywlmn+emFoU4eHpyX0cfz8KzPVIsQNSy3Uj7jrWkiQnkQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 16, 14, 9, 13, 787, DateTimeKind.Local).AddTicks(2278));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"), new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 16, 11, 41, 8, 879, DateTimeKind.Local).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 16, 14, 9, 13, 761, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 16, 11, 41, 8, 914, DateTimeKind.Local).AddTicks(4424));
        }
    }
}
