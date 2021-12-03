using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class tweaks03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "OccasionDescription", "OccasionName" },
                values: new object[] { "00", "Photos Home", "Home" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "00");
        }
    }
}
