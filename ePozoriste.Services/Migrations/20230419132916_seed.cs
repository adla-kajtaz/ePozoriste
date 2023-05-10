using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePozoriste.Services.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "DrzavaId", "Naziv", "Skracenica" },
                values: new object[] { 1, "Bosna i Hercegovina", "BiH" });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "DrzavaId", "Naziv", "Skracenica" },
                values: new object[] { 2, "Hrvatska", "HR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaId",
                keyValue: 2);
        }
    }
}
