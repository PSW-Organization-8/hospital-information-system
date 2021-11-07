using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyAPI.Migrations
{
    public partial class medication11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IngredientQuantity",
                columns: new[] { "Id", "Amount", "MediactionIngradientId", "MedicationId" },
                values: new object[,]
                {
                    { 1, 35.399999999999999, null, 1L },
                    { 2, 48.700000000000003, null, 2L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientQuantity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IngredientQuantity",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
