using Microsoft.EntityFrameworkCore.Migrations;

namespace EMarket.Data.Migrations
{
    public partial class AddingFkAndTwoColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Categories_CategorieId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Advertisements",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_CategorieId",
                table: "Advertisements",
                newName: "IX_Advertisements_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Advertisements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_Id",
                table: "Advertisements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_Id",
                table: "Advertisements",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Categories_CategoryId",
                table: "Advertisements",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_Id",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Categories_CategoryId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_Id",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategorieId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Advertisements",
                newName: "CategorieId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_CategoryId",
                table: "Advertisements",
                newName: "IX_Advertisements_CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Categories_CategorieId",
                table: "Advertisements",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
