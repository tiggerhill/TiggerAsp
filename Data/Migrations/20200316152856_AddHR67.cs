using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class AddHR67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[,]
                {
                    { 11, "Back row Michael, Francis and Cleveland, middle row their mother Orphia (Davis) Deevers and Debora and in front Russell", "HR67-001.jpg", "HR67", null },
                    { 12, "Brothers, Ed and Bill Hendrix", "HR67-002.jpg", "HR67", null },
                    { 13, "Judy (Hendrix) Bertelson", "HR67-003.jpg", "HR67", null },
                    { 14, "Jim Hendrix", "HR67-004.jpg", "HR67", null },
                    { 15, "Larry Hendrix", "HR67-005.jpg", "HR67", null },
                    { 16, "On the left, ?,Pat Hendrix, Diane Hendrix and Linda (Hendrix) Burson holding ?", "HR67-006.jpg", "HR67", null },
                    { 17, "In back Janice (Mrs Ed) Hendrix, Mary Ann (Mrs Jim) Hendrix and?, And in front Tony Hendrix and Diane Hendrix", "HR67-007.jpg", "HR67", null },
                    { 18, "Eddie (Hendrix) Stuart and Shirley Hendrix", "HR67-008.jpg", "HR67", null },
                    { 19, "Janice (Hendrix) Bartholomew and Larry Hendrix, sister and brother.", "HR67-009.jpg", "HR67", null },
                    { 20, "Kay (Hendrix) Reed and daughter Joy Reed", "HR67-010.jpg", "HR67", null },
                    { 21, "no description", "HR67-011.jpg", "HR67", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 21);
        }
    }
}
