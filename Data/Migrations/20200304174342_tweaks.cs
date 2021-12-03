using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class tweaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "NA",
                column: "OccasionName",
                value: "_Home");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "NA",
                column: "OccasionName",
                value: "Empty");
        }
    }
}
