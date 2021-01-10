using Microsoft.EntityFrameworkCore.Migrations;

namespace Negrea_Georgiana_proiect.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerID",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SellerID",
                table: "Product",
                column: "SellerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_SellerID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Product_SellerID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "Product");
        }
    }
}
