using Microsoft.EntityFrameworkCore.Migrations;

namespace Lends.Migrations
{
    public partial class addactivestatustorent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rent",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Rent",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Rent");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rent",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
