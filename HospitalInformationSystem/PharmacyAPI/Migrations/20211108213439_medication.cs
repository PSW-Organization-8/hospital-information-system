using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PharmacyAPI.Migrations
{
    public partial class medication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicationIngredient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationIngredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objection",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ObjectionIdFromHospitalDatabase = table.Column<long>(type: "bigint", nullable: false),
                    HopsitalName = table.Column<string>(type: "text", nullable: true),
                    TextObjection = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Adress = table.Column<string>(type: "text", nullable: true),
                    AdressNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistratedHospitals",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    ApiKey = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistratedHospitals", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ObjectionIdFromHospitalDatabase = table.Column<long>(type: "bigint", nullable: false),
                    HospitalName = table.Column<string>(type: "text", nullable: true),
                    TextResponse = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientQuantity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    MedicationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientQuantity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientQuantity_Medication_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medication",
                columns: new[] { "Id", "Name", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1L, "Paracetamol", 150, 0 },
                    { 2L, "Analgin", 50, 0 }
                });

            migrationBuilder.InsertData(
                table: "MedicationIngredient",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Vitamin C" },
                    { 2L, "Fosfor" },
                    { 3L, "Kalcijum" }
                });

            migrationBuilder.InsertData(
                table: "Objection",
                columns: new[] { "Id", "HopsitalName", "ObjectionIdFromHospitalDatabase", "TextObjection" },
                values: new object[] { 1L, "Ne valja nista", 0L, "Bolnica1" });

            migrationBuilder.InsertData(
                table: "Pharmacies",
                columns: new[] { "Id", "Adress", "AdressNumber", "City", "Name" },
                values: new object[,]
                {
                    { 1L, "Rumenačka", "15", "Novi Sad", "Jankovic" },
                    { 2L, "Bulevar oslobođenja", "135", "Novi Sad", "Jankovic" },
                    { 3L, "Olge Jovanović", "18a", "Beograd", "Jankovic" }
                });

            migrationBuilder.InsertData(
                table: "RegistratedHospitals",
                columns: new[] { "Name", "ApiKey", "Url" },
                values: new object[] { "Bolnica1", "fds15d4fs6", "http:localhost:7313" });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Id", "HospitalName", "ObjectionIdFromHospitalDatabase", "TextResponse" },
                values: new object[] { 1L, "Kleveta", 0L, "Bolnica1" });

            migrationBuilder.InsertData(
                table: "IngredientQuantity",
                columns: new[] { "Id", "Amount", "MedicationId" },
                values: new object[,]
                {
                    { 1, 35.399999999999999, 1L },
                    { 2, 48.700000000000003, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientQuantity_MedicationId",
                table: "IngredientQuantity",
                column: "MedicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientQuantity");

            migrationBuilder.DropTable(
                name: "MedicationIngredient");

            migrationBuilder.DropTable(
                name: "Objection");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "RegistratedHospitals");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Medication");
        }
    }
}
