using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class OccasionVsEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_FamilyEvents_FamilyEventId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "FamilyEvents");

            migrationBuilder.DropIndex(
                name: "IX_Photos_FamilyEventId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "FamilyEventId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "OccasionId",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Occasions",
                columns: table => new
                {
                    OccasionId = table.Column<string>(nullable: false),
                    OccasionName = table.Column<string>(nullable: true),
                    OccasionDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occasions", x => x.OccasionId);
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "OccasionDescription", "OccasionName" },
                values: new object[] { "EH", "Photos of Elisha and his children.", "Early Hendrix Photos" });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "OccasionDescription", "OccasionName" },
                values: new object[] { "HR67", "The very first Hendrix Reunion.", "Hendrix Reunion, 1967" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 2,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 3,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 4,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 5,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 6,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 7,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 8,
                column: "OccasionId",
                value: "EH");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_OccasionId",
                table: "Photos",
                column: "OccasionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Occasions_OccasionId",
                table: "Photos",
                column: "OccasionId",
                principalTable: "Occasions",
                principalColumn: "OccasionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Occasions_OccasionId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "Occasions");

            migrationBuilder.DropIndex(
                name: "IX_Photos_OccasionId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "OccasionId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "FamilyEventId",
                table: "Photos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FamilyEvents",
                columns: table => new
                {
                    FamilyEventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLongName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyEvents", x => x.FamilyEventId);
                });

            migrationBuilder.InsertData(
                table: "FamilyEvents",
                columns: new[] { "FamilyEventId", "EventDescription", "EventLongName" },
                values: new object[] { "EH", "Photos of Elisha and his children.", "Early Hendrix Photos" });

            migrationBuilder.InsertData(
                table: "FamilyEvents",
                columns: new[] { "FamilyEventId", "EventDescription", "EventLongName" },
                values: new object[] { "HR67", "The very first Hendrix Reunion.", "Hendrix Reunion, 1967" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 2,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 3,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 4,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 5,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 6,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 7,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 8,
                column: "FamilyEventId",
                value: "EH");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_FamilyEventId",
                table: "Photos",
                column: "FamilyEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_FamilyEvents_FamilyEventId",
                table: "Photos",
                column: "FamilyEventId",
                principalTable: "FamilyEvents",
                principalColumn: "FamilyEventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
