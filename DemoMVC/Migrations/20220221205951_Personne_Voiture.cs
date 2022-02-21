using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class Personne_Voiture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonneVoiture");

            migrationBuilder.AddColumn<string>(
                name: "Marque",
                table: "Voitures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoitureId",
                table: "Proprietaires",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proprietaires_VoitureId",
                table: "Proprietaires",
                column: "VoitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietaires_Voitures_VoitureId",
                table: "Proprietaires",
                column: "VoitureId",
                principalTable: "Voitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proprietaires_Voitures_VoitureId",
                table: "Proprietaires");

            migrationBuilder.DropIndex(
                name: "IX_Proprietaires_VoitureId",
                table: "Proprietaires");

            migrationBuilder.DropColumn(
                name: "Marque",
                table: "Voitures");

            migrationBuilder.DropColumn(
                name: "VoitureId",
                table: "Proprietaires");

            migrationBuilder.CreateTable(
                name: "PersonneVoiture",
                columns: table => new
                {
                    ProprietairesId = table.Column<int>(type: "int", nullable: false),
                    VoituresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneVoiture", x => new { x.ProprietairesId, x.VoituresId });
                    table.ForeignKey(
                        name: "FK_PersonneVoiture_Proprietaires_ProprietairesId",
                        column: x => x.ProprietairesId,
                        principalTable: "Proprietaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonneVoiture_Voitures_VoituresId",
                        column: x => x.VoituresId,
                        principalTable: "Voitures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonneVoiture_VoituresId",
                table: "PersonneVoiture",
                column: "VoituresId");
        }
    }
}
