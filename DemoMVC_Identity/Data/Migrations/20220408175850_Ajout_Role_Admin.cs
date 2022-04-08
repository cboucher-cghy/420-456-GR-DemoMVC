using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC_Identity.Data.Migrations
{
    public partial class Ajout_Role_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ce0a981-6965-4a1e-9b36-f330ea2651f7", "0609dc4a-a0c7-422b-98f1-a7f2fb6a23ce", "admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ce0a981-6965-4a1e-9b36-f330ea2651f7");
        }
    }
}
