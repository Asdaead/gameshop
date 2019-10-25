using Microsoft.EntityFrameworkCore.Migrations;

namespace gameshop.Migrations
{
    public partial class ShopCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShopCartItem",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ShopCartItem",
                newName: "Id");
        }
    }
}
