using Microsoft.EntityFrameworkCore.Migrations;

namespace Lends.Migrations
{
    public partial class changenameofrents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Producer_ProducerId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Client_ClientId",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Game_GameId",
                table: "Rent");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Producer_ProducerId",
                table: "Game",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Client_ClientId",
                table: "Rent",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Game_GameId",
                table: "Rent",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Producer_ProducerId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Client_ClientId",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Game_GameId",
                table: "Rent");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Producer_ProducerId",
                table: "Game",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Client_ClientId",
                table: "Rent",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Game_GameId",
                table: "Rent",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
