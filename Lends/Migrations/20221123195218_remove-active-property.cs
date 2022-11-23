using Microsoft.EntityFrameworkCore.Migrations;

namespace Lends.Migrations
{
    public partial class removeactiveproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Rent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Rent",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
