using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAPI.Migrations
{
    public partial class migracija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: "1",
                column: "Date",
                value: new DateTime(2021, 11, 3, 23, 39, 20, 454, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: "2",
                column: "Date",
                value: new DateTime(2021, 11, 3, 23, 39, 20, 458, DateTimeKind.Local).AddTicks(8590));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: "1",
                column: "Date",
                value: new DateTime(2021, 11, 3, 23, 28, 34, 698, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: "2",
                column: "Date",
                value: new DateTime(2021, 11, 3, 23, 28, 34, 702, DateTimeKind.Local).AddTicks(8791));
        }
    }
}
