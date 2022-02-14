using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class AddMarques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarqueId",
                table: "Modeles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Marque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marque", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modeles_MarqueId",
                table: "Modeles",
                column: "MarqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modeles_Marque_MarqueId",
                table: "Modeles",
                column: "MarqueId",
                principalTable: "Marque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeles_Marque_MarqueId",
                table: "Modeles");

            migrationBuilder.DropTable(
                name: "Marque");

            migrationBuilder.DropIndex(
                name: "IX_Modeles_MarqueId",
                table: "Modeles");

            migrationBuilder.DropColumn(
                name: "MarqueId",
                table: "Modeles");
        }
    }
}
