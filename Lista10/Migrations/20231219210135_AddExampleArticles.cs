using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lista10.Migrations
{
    public partial class AddExampleArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "ExpirationDate", "Name", "Price", "ProductCategory" },
                values: new object[] { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "carrot", 1.49, 1 });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "ExpirationDate", "Name", "Price", "ProductCategory" },
                values: new object[] { -2, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "broccoli", 2.4900000000000002, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
