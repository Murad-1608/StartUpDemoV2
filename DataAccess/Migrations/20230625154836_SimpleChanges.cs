using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SimpleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_ColorId",
                table: "ProductsToSales",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_ProductId",
                table: "ProductsToSales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_SizeId",
                table: "ProductsToSales",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TargetId",
                table: "Products",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Targets_TargetId",
                table: "Products",
                column: "TargetId",
                principalTable: "Targets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Colors_ColorId",
                table: "ProductsToSales",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Products_ProductId",
                table: "ProductsToSales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Sizes_SizeId",
                table: "ProductsToSales",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Targets_TargetId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Colors_ColorId",
                table: "ProductsToSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Products_ProductId",
                table: "ProductsToSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Sizes_SizeId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_ColorId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_ProductId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_SizeId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_Products_TargetId",
                table: "Products");
        }
    }
}
