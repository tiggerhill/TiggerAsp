using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class addphotohr67000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[] { 9, "Written by Stella (Wood) Hendrix.", "HR67-000.jpg", "HR67", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 9);
        }
    }
}
