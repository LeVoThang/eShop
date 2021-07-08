using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class FixDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle2");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle3");

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

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeKeyword", "This is keyword of eShopSolution" },
                    { "HomeDescription", "This is description of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "fab2a4fd-bbe5-495d-9e85-cc1850fc3084", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "149c9705-3d58-4011-8fe7-e8f730487499", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEHCYTjnBf/y3AiJyD/JIlnCOGflgSKkf6xmZDRdhei62ai/7TGtskX3D+poxhXguMw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Men Shirt");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeoTitle",
                value: "Sản phẩm áo thời trang women");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Women Shirt");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "viet-tien-men-t-shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 7, 17, 50, 47, 498, DateTimeKind.Local).AddTicks(6196));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle2", "This is home page of eShopSolution" },
                    { "HomeTitle3", "This is home page of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"), "8700643f-5596-40ef-bd2c-c6af47a6c54f", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"), new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"), 0, "cab2bd12-90e7-4d88-a3db-c59f5c67b273", new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "levothang.99@gmail.com", true, "Thang", "Vo", false, null, "levothang.99@gmail.com", "admin", "AQAAAAEAACcQAAAAEOGnwbld7kWIATG40Hnswacze0EP40N3t/S258JqUtO9z55SK5+s0mZrxzWr0p9Mcg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Men shirt");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeoTitle",
                value: "Sản phẩm áo thời trang nu");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Women shirt");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Sản phẩm áo sơ mi nam Việt Tiến", "Sản phẩm áo sơ mi nam Việt Tiến", "Áo sơ mi nam Việt Tiến", "ao-nam-viet-tien", "Sản phẩm áo sơ mi nam Việt Tiến", "Sản phẩm áo sơ mi nam Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men shirt", "Viet Tien Men shirt", "Viet Tien Men shirt", "Viet-tien-men-shirt", "Viet Tien Men shirt", "Viet Tien Men shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 5, 16, 44, 50, 962, DateTimeKind.Local).AddTicks(7838));
        }
    }
}
