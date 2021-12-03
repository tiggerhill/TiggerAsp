using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class InitialPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "UploadedBy" },
                values: new object[,]
                {
                    { 1, "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Bill, Chet, Ed. Middle, Ruby, Jessie and Elisha; Front, Oliver and Jim.", "EH-001.jpg", null },
                    { 2, "Bill, Ed, Chet and Elisha Hendrix. All three are sons of Elisha. Taken at their home in Davis City, IA in 1936", "EH-002.jpg", null },
                    { 3, "The first one on the left is Oliver. He is very young here!", "EH-003.jpg", null },
                    { 4, "Oliver on left, Chet, Jessie, Ed, Bill, Jim and Ruby (not in picture) are all children of Elisha and Orpha (Hazlett) Hendrix!, taken fall of 1944.", "EH-004.jpg", null },
                    { 5, "Oliver and Jim, sons of Elisha and Orpha (Hazlett) Hendrix. Taken in 1944 on Chet and Mildred (Baughman) Hendrix's farm at Leon, Iowa.", "EH-005.jpg", null },
                    { 6, " Elisha and Orpha (Hazlett) Hendrix's sons. Chet standing on top of hay, Ed on left and Oliver, putting up hay on Chet's farm at Leon, Iowa in 1943..", "EH-006.jpg", null },
                    { 7, "Elisha and Orpha (Hazlett) Hendrix's sons. Oliver and Bill (on tractor), stacking hay on a farm around Leon, Iowa in 1939.", "EH-007.jpg", null },
                    { 8, "Oliver.", "EH-008.jpg", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
