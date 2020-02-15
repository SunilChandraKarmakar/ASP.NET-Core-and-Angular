using Microsoft.EntityFrameworkCore.Migrations;

namespace Db_Context.Migrations
{
    public partial class Customer_ContactNo_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Customers",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContactNo",
                table: "Customers",
                column: "ContactNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_ContactNo",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Customers");
        }
    }
}
