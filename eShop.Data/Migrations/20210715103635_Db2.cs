using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class Db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dc56c2b5-0841-4239-bcd8-2e929a53f097");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e061865-5b32-46c4-9809-3772cfda1a79", "AQAAAAEAACcQAAAAEIwH8M5ytCjmqSEhczxxPiySSBBgWb0uzJAPiPcNPbqQ160BLwUeOJOifbfLC1Ai/A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 17, 36, 33, 859, DateTimeKind.Local).AddTicks(9409));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fab2a4fd-bbe5-495d-9e85-cc1850fc3084");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "149c9705-3d58-4011-8fe7-e8f730487499", "AQAAAAEAACcQAAAAEHCYTjnBf/y3AiJyD/JIlnCOGflgSKkf6xmZDRdhei62ai/7TGtskX3D+poxhXguMw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 7, 17, 50, 47, 498, DateTimeKind.Local).AddTicks(6196));
        }
    }
}
