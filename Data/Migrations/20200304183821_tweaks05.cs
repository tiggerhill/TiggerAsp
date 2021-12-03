using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class tweaks05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 10,
                column: "Description",
                value: "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Bill, Chet, Ed. Middle, Ruby, Jessie and Elisha; Front, Oliver and Jim.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 10,
                column: "Description",
                value: "Default");
        }
    }
}
