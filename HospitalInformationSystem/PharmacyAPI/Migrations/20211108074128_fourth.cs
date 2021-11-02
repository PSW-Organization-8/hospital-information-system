using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyAPI.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegistratedHospitals",
                columns: new[] { "Name", "ApiKey", "Url" },
                values: new object[] { "Bolnica1", "fds15d4fs6", "http:localhost:7313" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegistratedHospitals",
                keyColumn: "Name",
                keyValue: "Bolnica1");
        }
    }
}
