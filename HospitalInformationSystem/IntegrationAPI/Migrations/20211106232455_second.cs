using Microsoft.EntityFrameworkCore.Migrations;

namespace IntegrationAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ApiKey",
                value: "fds15d4fs6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ApiKey",
                value: "asd123easd");
        }
    }
}
