using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class tweaks04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[] { 10, "Default", "EH-001downsizedframed.jpg", "00", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 10);
        }
    }
}
