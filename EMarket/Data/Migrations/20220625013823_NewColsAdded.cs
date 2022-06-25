using Microsoft.EntityFrameworkCore.Migrations;

namespace EMarket.Data.Migrations
{
    public partial class NewColsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertesiments_Categories_CategorieId",
                table: "Advertesiments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertesiments",
                table: "Advertesiments");

            migrationBuilder.RenameTable(
                name: "Advertesiments",
                newName: "Advertisements");

            migrationBuilder.RenameIndex(
                name: "IX_Advertesiments_CategorieId",
                table: "Advertisements",
                newName: "IX_Advertisements_CategorieId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements",
                column: "AdvertesimentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Categories_CategorieId",
                table: "Advertisements",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Categories_CategorieId",
                table: "Advertisements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Advertisements",
                newName: "Advertesiments");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_CategorieId",
                table: "Advertesiments",
                newName: "IX_Advertesiments_CategorieId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertesiments",
                table: "Advertesiments",
                column: "AdvertesimentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertesiments_Categories_CategorieId",
                table: "Advertesiments",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
