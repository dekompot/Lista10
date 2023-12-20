using Microsoft.EntityFrameworkCore.Migrations;

namespace Lista10.Migrations
{
    public partial class AddExamples : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCategory",
                table: "Student",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "ArticleId");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { -1, "Vegetables" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { -2, "Others" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ArticleId",
                keyValue: -2,
                column: "CategoryId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ArticleId",
                keyValue: -1,
                column: "CategoryId",
                value: -1);

            migrationBuilder.CreateIndex(
                name: "IX_Student_CategoryId",
                table: "Student",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Category_CategoryId",
                table: "Student",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Category_CategoryId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Student_CategoryId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Student",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Student",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -2,
                column: "ProductCategory",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -1,
                column: "ProductCategory",
                value: 1);
        }
    }
}
