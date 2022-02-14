using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class AddMarquesInDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeles_Marque_MarqueId",
                table: "Modeles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marque",
                table: "Marque");

            migrationBuilder.RenameTable(
                name: "Marque",
                newName: "Marques");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marques",
                table: "Marques",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modeles_Marques_MarqueId",
                table: "Modeles",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeles_Marques_MarqueId",
                table: "Modeles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marques",
                table: "Marques");

            migrationBuilder.RenameTable(
                name: "Marques",
                newName: "Marque");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marque",
                table: "Marque",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modeles_Marque_MarqueId",
                table: "Modeles",
                column: "MarqueId",
                principalTable: "Marque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
