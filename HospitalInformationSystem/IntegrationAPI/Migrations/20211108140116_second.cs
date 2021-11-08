using Microsoft.EntityFrameworkCore.Migrations;

namespace IntegrationAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PharmacyName",
                table: "Response",
                newName: "ObjectionId");

            migrationBuilder.UpdateData(
                table: "Response",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ObjectionId",
                value: "1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObjectionId",
                table: "Response",
                newName: "PharmacyName");

            migrationBuilder.UpdateData(
                table: "Response",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PharmacyName",
                value: "Apoteka1");
        }
    }
}
