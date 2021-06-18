using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 16, 14, 9, 13, 761, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 16, 14, 9, 13, 761, DateTimeKind.Local).AddTicks(4309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8699ef4a-3fe5-4a6a-9525-b007f2002265"),
                column: "ConcurrencyStamp",
                value: "1c599d7e-1c38-47d6-9c0f-7dcffa1f333e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("925948cc-a1e0-4162-aeeb-86dc1262d9ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "524d3ad4-86b2-4736-9d99-81ef05730fdd", "AQAAAAEAACcQAAAAEOyMjY9qUnJdVDVdyPNUZywlmn+emFoU4eHpyX0cfz8KzPVIsQNSy3Uj7jrWkiQnkQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 16, 14, 9, 13, 787, DateTimeKind.Local).AddTicks(2278));
        }
    }
}
