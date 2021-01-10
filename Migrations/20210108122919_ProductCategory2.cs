using Microsoft.EntityFrameworkCore.Migrations;

namespace Negrea_Georgiana_proiect.Migrations
{
    public partial class ProductCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
