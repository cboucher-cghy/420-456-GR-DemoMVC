using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acronyme = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Argent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modeles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarqueId = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    PDSF = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeles_Marques_MarqueId",
                        column: x => x.MarqueId,
                        principalTable: "Marques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProprietairesVoitures",
                columns: table => new
                {
                    ProprietaireId = table.Column<int>(type: "int", nullable: false),
                    VoitureId = table.Column<int>(type: "int", nullable: false),
                    DateAcquisition = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    PrixPaye = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProprietairesVoitures", x => new { x.ProprietaireId, x.VoitureId });
                    table.ForeignKey(
                        name: "FK_ProprietairesVoitures_Modeles_VoitureId",
                        column: x => x.VoitureId,
                        principalTable: "Modeles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProprietairesVoitures_Proprietaires_ProprietaireId",
                        column: x => x.ProprietaireId,
                        principalTable: "Proprietaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Acronyme", "Nom" },
                values: new object[,]
                {
                    { 1, null, "Audi" },
                    { 2, null, "BMW" },
                    { 3, null, "Lexus" },
                    { 4, null, "Mazda" },
                    { 5, null, "Honda" },
                    { 6, null, "Hyundai" },
                    { 7, null, "Kia" },
                    { 8, null, "Chevrolet" },
                    { 9, null, "Ferrari" }
                });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "Annee", "MarqueId", "Nom", "PDSF" },
                values: new object[,]
                {
                    { 1, 2006, 1, "A3", 79000.009999999995 },
                    { 2, 2032, 1, "A4", 99999.990000000005 },
                    { 3, 2022, 2, "X5", 81000.0 },
                    { 4, 2020, 2, "X5 M", 81500.0 },
                    { 5, 2019, 2, "M6", 111500.50999999999 },
                    { 6, 2020, 2, "i8", 121500.50999999999 },
                    { 7, 2021, 2, "i8", 111500.50999999999 },
                    { 8, 2020, 3, "RX", 42500.0 },
                    { 9, 2020, 3, "CT", 53000.0 },
                    { 10, 2021, 3, "CT", 62500.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modeles_MarqueId",
                table: "Modeles",
                column: "MarqueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProprietairesVoitures_VoitureId",
                table: "ProprietairesVoitures",
                column: "VoitureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProprietairesVoitures");

            migrationBuilder.DropTable(
                name: "Modeles");

            migrationBuilder.DropTable(
                name: "Proprietaires");

            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
