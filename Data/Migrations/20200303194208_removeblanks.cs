using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class removeblanks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "EH",
                column: "OccasionName",
                value: "EarlyHendrixPhotos");

            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR67",
                column: "OccasionName",
                value: "HendrixReunion1967");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "EH",
                column: "OccasionName",
                value: "Early Hendrix Photos");

            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR67",
                column: "OccasionName",
                value: "Hendrix Reunion, 1967");
        }
    }
}
