using Microsoft.EntityFrameworkCore.Migrations;

namespace Lends.Migrations
{
    public partial class changingrentvaluetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RentPrice",
                table: "Game",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "RentPrice",
                table: "Game",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
