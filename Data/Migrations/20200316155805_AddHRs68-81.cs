using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class AddHRs6881 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[,]
                {
                    { 22, "written by Stella Wood Hendrix", "HR68-001.jpg", "HR68", null },
                    { 54, "Mike and his Dad, Larry Hendrix", "HR78-004.jpg", "HR78", null },
                    { 55, "Ralph Bethards and his Step-Mother, Jessie (Hendrix) Bethards", "HR78-005.jpg", "HR78", null },
                    { 56, "In front, Mildred (Mrs Chet) Hendrix, Janice (Hendrix) (Mrs Fred) James, Mike (Kellie) Hendrix, ?, and Donnie (Marla) Hendrix", "HR78-006.jpg", "HR78", null },
                    { 57, "Larry and Reta Hendrix and brother Gary Hendrix", "HR78-007.jpg", "HR78", null },
                    { 58, "Oliver Hendrix and Donnie Hendrix", "HR78-008.jpg", "HR78", null },
                    { 59, "Betty (Mrs Oliver) Hendrix", "HR78-009.jpg", "HR78", null },
                    { 60, "Mildred (Mrs Chet) Hendrix, not sure who the little boy is, and Betty (Mrs Oliver) Hendrix, sister-in-laws! Little boy could be Darin Donnie and Marla Hendrix's son?", "HR78-010.jpg", "HR78", null },
                    { 61, "written by Stella (Wood) Hendrix", "HR78-011.jpg", "HR78", null },
                    { 62, "Mike Hendrix on left", "HR78-012.jpg", "HR78", null },
                    { 63, "Harold Hendrix", "HR78-013.jpg", "HR78", null },
                    { 64, "no description", "HR78-014.jpg", "HR78", null },
                    { 65, "Janice James Behind ?, Mildred (Mrs Chet) Hendrix, Janice (Mrs Ed) Hendrix, front Kay (Mrs Jack) Reed and ? (I just can't decide which one of the boys that is) Kay Reed Jim Stuart jr.", "HR78-015.jpg", "HR78", null },
                    { 53, "no description", "HR78-003.jpg", "HR78", null },
                    { 66, "Hendrix cousins, Harold and Donnie!", "HR78-016.jpg", "HR78", null },
                    { 68, "Kay Reed Pat HendrixLease Kay Hendrix Reed Jim Stuart Jr joyce Hendrix and I think the one on the left is Tom Bertelson Judy Hendrix Bertelsons son Janice James Kay, between Jim and Joyce is another lady, not sure who she is? Is that your Mom standing up? Then Tom on the right, Tom and Judy Bertelson's son! Thanks for your help! As you have time, will you check other pictures to see if I have them correct!", "HR78-018.jpg", "HR78", null },
                    { 69, "Hendrix brothers, Ed on left (Janice) and Bill (Stella)", "HR78-019.jpg", "HR78", null },
                    { 70, "Kathy and Dennis Hendrix, Kathy holding Tacy, Tonya and Dennis holding Troy", "HR81-001.jpg", "HR81", null },
                    { 71, "These are four of the Hendrix brothers; Chet, Oliver, Ed and Bill. Their brother Jim could not be there.", "HR81-002.jpg", "HR81", null },
                    { 72, "Mary (Mrs Harold) Hendrix with son David", "HR81-003.jpg", "HR81", null },
                    { 73, "These are all Hendrix cousins! On the left of table are Donnie, Gary and Denny and right side are Harold and Dick!", "HR81-004.jpg", "HR81", null },
                    { 74, "Larry Hendrix, then-wife Rita, and daughter Michelle, with Chet Hendrix", "HR81-005.jpg", "HR81", null },
                    { 75, "no description", "HR81-006.jpg", "HR81", null },
                    { 76, "Eddie (Hendrix) (Mrs Jim) Stuart and granddaughter Nicole Stuart", "HR81-007.jpg", "HR81", null },
                    { 77, " Hendrix cousins, Gary Hendrix and Kay (Hendrix) (Mrs Jack) Reed!", "HR81-008.jpg", "HR81", null },
                    { 78, "Pat (Hendrix) (Mrs Ron) Lease", "HR81-009.jpg", "HR81", null },
                    { 79, "Shirley (Hendrix) and Bob Morton.", "HR81-010.jpg", "HR81", null },
                    { 67, "Marla ( Mrs Donnie) Hendrix", "HR78-017.jpg", "HR78", null },
                    { 52, "Ed and Janice's family", "HR78-002.jpg", "HR78", null },
                    { 51, "written by Stella (Wood) Hendrix", "HR78-001.jpg", "HR78", null },
                    { 50, "Greg, Michelle, Chari, Tony and Brad", "HR77-007.jpg", "HR77", null },
                    { 23, "no description", "HR68-002.jpg", "HR68", null },
                    { 24, "Eddie (Hendrix) Stuart, Gayle Hendrix, Joyce and daughter Debbie Hendrix", "HR68-003.jpg", "HR68", null },
                    { 25, "On the front bench are Norman and Linda (Hendrix) Burson and children, Doug and Chari. Beside Linda is Marcella (Mrs Art) Wood. Back row ?, Janice (Mrs Ed) Hendrix and ?", "HR68-004.jpg", "HR68", null },
                    { 26, "no description", "HR68-005.jpg", "HR68", null },
                    { 27, "Elizabeth, Dianna and their parents, LaDonna and Floyd Green.", "HR68-006.jpg", "HR68", null },
                    { 28, "Dick and Gayle Hendrix", "HR68-007.jpg", "HR68", null },
                    { 29, "Janice (Ed Hendrix), Diane and her mother Mary Ann (Jim Hendrix)", "HR68-008.jpg", "HR68", null },
                    { 30, "In back, left Janice (Mrs Ed) Hendrix, Joyce (Mrs Ron) Hendrix and Mary Ann (Mrs Jim) Hendrix. In front, man in white shirt ?, and Jim Hendrix. I think the guy in the white shirt is Art Wood, Stella (Wood), (Mrs Bill) Hendrix's brother.", "HR68-009.jpg", "HR68", null },
                    { 31, "I think those are the Dreevers sons, maybe their Dad and Ed Hendrix.", "HR68-010.jpg", "HR68", null },
                    { 32, "written by Stella (Wood) Hendrix", "HR76-001.jpg", "HR76", null },
                    { 33, "Oliver Hendrix", "HR76-002.jpg", "HR76", null },
                    { 34, "Larry Hendrix (I think...) and his dad, Bill.", "HR76-003.jpg", "HR76", null },
                    { 35, "Tom Bertelson (Judy Hendrix) and Jack Reed (Kay Hendrix)", "HR76-004.jpg", "HR76", null },
                    { 36, "no description", "HR76-005.jpg", "HR76", null },
                    { 37, "no description", "HR76-006.jpg", "HR76", null },
                    { 38, "no description", "HR76-007.jpg", "HR76", null },
                    { 39, "Gary Hendrix", "HR76-008.jpg", "HR76", null },
                    { 40, "no description", "HR76-009.jpg", "HR76", null },
                    { 41, "no description", "HR76-010.jpg", "HR76", null },
                    { 42, "no description", "HR76-011.jpg", "HR76", null },
                    { 43, "Bill Hendrix", "HR76-012.jpg", "HR76", null },
                    { 44, "captured from Stella (Wood) Hendrix's photo albumn", "HR77-001.jpg", "HR77", null },
                    { 45, "no description", "HR77-002.jpg", "HR77", null },
                    { 46, "Janice ( Hendrix) Bartholomew on right", "HR77-003.jpg", "HR77", null },
                    { 47, "Shirley (Hendrix)Morton in background, Chet Hendrix and Pat (Hendrix) Lease", "HR77-004.jpg", "HR77", null },
                    { 48, "Greg Hendrix, Michelle Hendrix, Chari Burson, Tony Hendrix and in front Brad Bartholomew", "HR77-005.jpg", "HR77", null },
                    { 49, "Chari Burson on right", "HR77-006.jpg", "HR77", null },
                    { 80, "no description", "HR81-011.jpg", "HR81", null },
                    { 81, "Ed and Janice Hendrix family - Shirley, Kay, Eddie, Ed, Janice, Dick, Judy and Pat !", "HR81-012.jpg", "HR81", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 81);
        }
    }
}
