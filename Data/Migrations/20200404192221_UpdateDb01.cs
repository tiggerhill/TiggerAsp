using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class UpdateDb01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 246);

            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "00",
                columns: new[] { "OccasionDescription", "OccasionName" },
                values: new object[] { "All Photos", "All" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                column: "Description",
                value: "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Ed, Chet, and Bill. Middle, Elisah, Jessie and Ruby; Front, Jim and Oliver.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 6,
                column: "Description",
                value: "Elisha and Orpha (Hazlett) Hendrix's sons. Chet standing on top of hay, Ed on left and Oliver, putting up hay on Chet's farm at Leon, Iowa in 1943.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 9,
                column: "Description",
                value: "written by Stella (Wood) Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 11,
                column: "Description",
                value: "Back row: Michael, Francis and Cleveland; middle row: their mother Orphia (Davis) Deevers and Debora; and in front: Russell.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 16,
                column: "Description",
                value: "Pat Hendrix, Diane Hendrix and Linda (Hendrix) Burson holding Michelle Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 17,
                column: "Description",
                value: "Back: Janice (Mrs Ed) Hendrix, Mary Ann (Mrs Jim) Hendrix and Joy Reed; Front: Tony Hendrix and Diane Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 21,
                column: "Description",
                value: "Reta (Mrs Larry) Hendrix and daughter Michelle");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 23,
                column: "Description",
                value: "Ed and Orphia Deevers");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 26,
                column: "Description",
                value: "Ed and Orphia Deevers and their four sons, Cleveland, Francis, Michael and Russell (not necessarily in that order)");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 30,
                column: "Description",
                value: "In back, left Janice (Mrs Ed) Hendrix, Joyce (Mrs Ron) Hendrix and Mary Ann (Mrs Jim) Hendrix. In front, Art Wood, Stella (Wood), (Mrs Bill) Hendrix's brother, and Jim Hendrix.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 31,
                column: "Description",
                value: "Jim (Eddie Hendrix) Stuart with sons Jimmy and Mark");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 34,
                column: "Description",
                value: "Larry Hendrix and his dad, Bill");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 36,
                column: "Description",
                value: "Gayle Marsh (girlfriend of Dick Hendrix) in back, Eddie (Hendrix) Stuart and Shirley Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 37,
                column: "Description",
                value: "Ed Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 38,
                column: "Description",
                value: "Eddie (Hendrix) Stuart");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 40,
                column: "Description",
                value: "Donnie Hendrix with Chari (Burson) McEvoy looking on");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 41,
                column: "Description",
                value: "Ron and Pat (Hendrix) Lease");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 42,
                column: "Description",
                value: "Ronnie Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 45,
                column: "Description",
                value: "Donny and Ronny Hendrix, Gary Hendrix in the green shirt, Harold Hendrix leaning on the car and Chet Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 46,
                column: "Description",
                value: "Janice (Hendrix) Bartholomew on right");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 47,
                column: "Description",
                value: "Shirley (Hendrix) Morton in background, Chet Hendrix and Pat (Hendrix) Lease");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 53,
                column: "Description",
                value: "Betty (Mrs Oliver) Hendrix, left front!");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 64,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Behind ?, Mildred (Mrs Chet) Hendrix, Janice (Mrs Ed) Hendrix, front Kay (Mrs Jack) Reed and Jim Stuart Jr.", "HR78-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 65,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Hendrix cousins, Harold on left (Mary), and Donnie (Marla)", "HR78-016.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 66,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Marla (Mrs Donnie) Hendrix", "HR78-017.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 67,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Pat (Hendrix) Lease, Kay Hendrix, Jim Stuart Jr, Michele Stewart, Joyce Hendrix, Ron Hendrix, Tom Bertelson", "HR78-018.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 68,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Hendrix brothers, Ed on left (Janice) and Bill (Stella)", "HR78-019.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 69,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Kathy and Dennis Hendrix, with family:  Tacy, Tonya and Troy", "HR81-001.jpg", "HR81" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 70,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "These are four of the Hendrix brothers; Chet, Oliver, Ed and Bill. Their brother Jim could not be there.", "HR81-002.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 71,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Mary (Mrs Harold) Hendrix with son David", "HR81-003.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 72,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "These are all Hendrix cousins! On the left of table are Donnie, Gary and Denny and right side are Harold and Dick!", "HR81-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 73,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Larry Hendrix, then-wife Rita, and daughter Michelle, with Chet Hendrix", "HR81-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 74,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Eddie (Hendrix) (Mrs Jim) Stuart and granddaughter Nicole Stuart", "HR81-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 75,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Hendrix cousins, Gary Hendrix and Kay (Hendrix) (Mrs Jack) Reed!", "HR81-008.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 76,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Pat (Hendrix) (Mrs Ron) Lease", "HR81-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 77,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Shirley (Hendrix) and Bob Morton.", "HR81-010.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 78,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Ed and Janice Hendrix family - Shirley, Kay, Eddie, Ed, Janice, Dick, Judy and Pat !", "HR81-012.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 79,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Ed (Janice) Hendrix, Fred/Sonny (Janice) James, Ralph Bethards, Bill (Stella) Hendrix and Chet (Mildred) Hendrix", "HR82-001.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 80,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Jessie (Hendrix) (Mrs Otto) Bethards and Betty (Mrs Oliver) Hendrix", "HR82-002.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 81,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Randy and Paula Hendrix and their children Jason and Rene", "HR82-003.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 82,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Harold Hendrix and Dick Hendrix, cousins", "HR84-001.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 83,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Sonny, Janice and their son Brad James", "HR84-002.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 84,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Don and Marla Hendrix and children, Darci, Deena and Darin", "HR84-003.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 85,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Marla (Mrs Don) and her mother-in-law Mildred (Mrs Chet) Hendrix", "HR84-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 86,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Gary Hendrix", "HR84-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 87,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Pat (Hendrix) and Ron Lease", "HR84-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 88,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "David Hendrix", "HR84-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 89,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Mildred and Chet Hendrix and granddaughter Darci", "HR84-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 90,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Joyce and Ron Hendrix", "HR85-001.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 91,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Joyce (Mrs Ron) Hendrix and Mildred (Mrs Chet) Hendrix", "HR85-002.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 92,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Linda (Hendrix) Burson", "HR85-004.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 93,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Harold Hendrix, Janice (Hendrix) James in background and Oliver and Betty Hendrix seated!", "HR85-005.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 94,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Jim and Mary Ann Hendrix!", "HR85-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 95,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold Hendrix, Brad James and Oliver Hendrix seated!", "HR85-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 96,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Brad James in background, Mary and Harold Hendrix, Oliver Hendrix and Jessie (Hendrix) Bethards in front!", "HR85-008.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 97,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Baby Andrew born June 30th to Randy and Paula Hendrix", "HR85-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 98,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Rick and Rachel Hendrix", "HR85-010.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 99,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "David and Harold Hendrix, Larry Hendrix, Janice (Hendrix) James, Linda (Hendrix) Burson, Gary Hendrix", "HR85-011.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 100,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Bill Hendrix", "HR85-013.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 101,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "back, Jim, Chet, Bill, and Ed; front, Oliver, all Hendrix brother and their sister, Jessie (Hendrix) Bethards", "HR85-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 102,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Jason Morton", "HR85-016.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 103,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Don Hendrix and Ed Hendrix", "HR85-017.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 104,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Jim and Mary Ann Hendrix and Jessie (Hendrix) Bethards in front!", "HR85-018.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 105,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Mary (Mrs Harold) Hendrix and Shirley (Hendrix) Morton", "HR85-020.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 106,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harry and Sandra (Hendrix) Kennedy", "HR85-021.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 107,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "from left - Don Hendrix, Jim Hendrix, Linda (Hendrix) Burson and Larry Hendrix", "HR85-022.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 108,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Jessie (Hendrix) Bethards and Darci Hendrix", "HR85-024.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 109,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-001.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 110,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-002.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 111,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-003.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 112,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-004.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 113,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-005.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 114,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Don Hendrix in back, son Darin, wife Marla, father Chet, mother Mildred and daughter's Darci and Deena", "HR86-006.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 115,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-007.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 116,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "back: Brad James, Gary Hendrix, Janice and Sonny James; front: Bill and Stella Hendrix, Harold Hendrix with David, Larry Hendrix with Erika and Jeremy", "HR86-008.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 117,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Jessie (Hendrix) Bethards", "HR86-009.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 118,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Uncle Jim and Aunt Mary Ann Hendrix", "HR86-010.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 119,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Aunt Mary Ann (Jim) Hendrix (back) and Janice James", "HR86-011.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 120,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Michelle (Hendrix) and Lonnie Dwyer", "HR86-012.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 121,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Brad, Sonny and Janice James", "HR86-013.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 122,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold and David Hendrix", "HR86-014.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 123,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Aunt Betty and Uncle Oliver Hendrix", "HR86-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 124,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Brothers, Chet, Oliver and Ed Hendrix", "HR86-016.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 125,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Ed and Janice Hendrix", "HR86-017.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 126,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Kathy and Dennis Hendrix and children Troy, Tacy and Tonya", "HR86-018.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 127,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-019.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 128,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-020.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 129,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-021.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 130,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-022.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 131,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Oliver, Jessie(Hendrix) Bethards, Jim, Bill and Chet. All Hendrix brothers and sister", "HR86-023.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 132,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Oliver, Jessie (Bethards) Hendrix, Jim, Bill and Chet. All Hendrix brothers and sister!", "HR86-024.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 133,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Janice (Hendrix) and Sonny James", "HR86-025.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 134,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Larry, Kellie, Mike, Jeremy and Erica Hendrix", "HR86-026.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 135,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Stella (Wood) and Bill Hendrix", "HR86-027.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 136,
                column: "FileName",
                value: "HR86-028.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 137,
                column: "FileName",
                value: "HR86-029.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 138,
                column: "FileName",
                value: "HR86-030.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 139,
                column: "FileName",
                value: "HR86-031.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 140,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Mike, Jeremy and Erica Hendrix", "HR86-032.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 141,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-033.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 142,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-034.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 143,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-035.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 144,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-036.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 145,
                column: "FileName",
                value: "HR86-037.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 146,
                column: "FileName",
                value: "HR86-038.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 147,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-001.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 148,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-002.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 149,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR87-003.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 150,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-004.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 151,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-005.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 152,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-006.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 153,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-007.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 154,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-008.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 155,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-009.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 156,
                column: "FileName",
                value: "HR87-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 157,
                column: "FileName",
                value: "HR87-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 158,
                column: "FileName",
                value: "HR87-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 159,
                column: "FileName",
                value: "HR87-013.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 160,
                column: "FileName",
                value: "HR87-014.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 161,
                column: "FileName",
                value: "HR87-015.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 162,
                column: "FileName",
                value: "HR87-016.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 163,
                column: "FileName",
                value: "HR87-017.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 164,
                column: "FileName",
                value: "HR87-018.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 165,
                column: "FileName",
                value: "HR87-019.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 166,
                column: "FileName",
                value: "HR87-020.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 167,
                column: "FileName",
                value: "HR87-021.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 168,
                column: "FileName",
                value: "HR87-022.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 169,
                column: "FileName",
                value: "HR87-023.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 170,
                column: "FileName",
                value: "HR87-024.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 171,
                column: "FileName",
                value: "HR87-025.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 172,
                column: "FileName",
                value: "HR87-026.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 173,
                column: "FileName",
                value: "HR87-027.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 174,
                column: "FileName",
                value: "HR87-028.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 175,
                column: "FileName",
                value: "HR87-029.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 176,
                column: "FileName",
                value: "HR87-030.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 177,
                column: "FileName",
                value: "HR87-031.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 178,
                column: "FileName",
                value: "HR87-032.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 179,
                column: "FileName",
                value: "HR87-033.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 180,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-001.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 181,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-002.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 182,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-003.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 183,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-004.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 184,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-005.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 185,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-006.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 186,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-007.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 187,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-008.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 188,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-009.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 189,
                column: "FileName",
                value: "HR88-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 190,
                column: "FileName",
                value: "HR88-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 191,
                column: "FileName",
                value: "HR88-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 192,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-001.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 193,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-002.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 194,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-003.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 195,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-004.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 196,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-005.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 197,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-006.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 198,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-007.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 199,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-008.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 200,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-009.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 201,
                column: "FileName",
                value: "HR89-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 202,
                column: "FileName",
                value: "HR89-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 203,
                column: "FileName",
                value: "HR89-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 204,
                column: "FileName",
                value: "HR89-013.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 205,
                column: "FileName",
                value: "HR89-014.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 206,
                column: "FileName",
                value: "HR89-015.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 207,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-001.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 208,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-002.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 209,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-003.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 210,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-004.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 211,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-005.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 212,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-006.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 213,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-007.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 214,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-008.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 215,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR90-009.jpg", "HR90" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 216,
                column: "FileName",
                value: "HR90-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 217,
                column: "FileName",
                value: "HR90-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 218,
                column: "FileName",
                value: "HR90-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 219,
                column: "FileName",
                value: "HR90-013.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 220,
                column: "FileName",
                value: "HR90-014.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 221,
                column: "FileName",
                value: "HR90-015.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 222,
                column: "FileName",
                value: "HR90-016.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 223,
                column: "FileName",
                value: "HR90-017.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 224,
                column: "FileName",
                value: "HR90-018.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 225,
                column: "FileName",
                value: "HR90-019.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 226,
                column: "FileName",
                value: "HR90-020.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 227,
                column: "FileName",
                value: "HR90-021.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 228,
                column: "FileName",
                value: "HR90-022.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 229,
                column: "FileName",
                value: "HR90-023.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 230,
                column: "FileName",
                value: "HR90-024.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 231,
                column: "FileName",
                value: "HR90-025.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 232,
                column: "FileName",
                value: "HR90-026.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 233,
                column: "FileName",
                value: "HR90-027.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 234,
                column: "FileName",
                value: "HR90-028.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 235,
                column: "FileName",
                value: "HR90-029.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 236,
                column: "FileName",
                value: "HR90-030.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 237,
                column: "FileName",
                value: "HR90-031.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "00",
                columns: new[] { "OccasionDescription", "OccasionName" },
                values: new object[] { "Photos Home", "Home" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                column: "Description",
                value: "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Bill, Chet, Ed. Middle, Ruby, Jessie and Elisha; Front, Oliver and Jim.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 6,
                column: "Description",
                value: "Elisha and Orpha (Hazlett) Hendrix's sons. Chet standing on top of hay, Ed on left and Oliver, putting up hay on Chet's farm at Leon, Iowa in 1943..");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 9,
                column: "Description",
                value: "written by Stella Wood Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 11,
                column: "Description",
                value: "Back row Michael, Francis and Cleveland, middle row their mother Orphia (Davis) Deevers and Debora and in front Russell");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 16,
                column: "Description",
                value: "On the left, ?,Pat Hendrix, Diane Hendrix and Linda (Hendrix) Burson holding ?");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 17,
                column: "Description",
                value: "In back Janice (Mrs Ed) Hendrix, Mary Ann (Mrs Jim) Hendrix and?, And in front Tony Hendrix and Diane Hendrix");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 21,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 23,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 26,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 30,
                column: "Description",
                value: "In back, left Janice (Mrs Ed) Hendrix, Joyce (Mrs Ron) Hendrix and Mary Ann (Mrs Jim) Hendrix. In front, man in white shirt ?, and Jim Hendrix. I think the guy in the white shirt is Art Wood, Stella (Wood), (Mrs Bill) Hendrix's brother.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 31,
                column: "Description",
                value: "I think those are the Dreevers sons, maybe their Dad and Ed Hendrix.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 34,
                column: "Description",
                value: "Larry Hendrix (I think...) and his dad, Bill.");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 36,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 37,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 38,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 40,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 41,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 42,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 45,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 46,
                column: "Description",
                value: "Janice ( Hendrix) Bartholomew on right");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 47,
                column: "Description",
                value: "Shirley (Hendrix)Morton in background, Chet Hendrix and Pat (Hendrix) Lease");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 53,
                column: "Description",
                value: "no description");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 64,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR78-014.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 65,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Janice James Behind ?, Mildred (Mrs Chet) Hendrix, Janice (Mrs Ed) Hendrix, front Kay (Mrs Jack) Reed and ? (I just can't decide which one of the boys that is) Kay Reed Jim Stuart jr.", "HR78-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 66,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Hendrix cousins, Harold and Donnie!", "HR78-016.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 67,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Marla ( Mrs Donnie) Hendrix", "HR78-017.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 68,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Kay Reed Pat HendrixLease Kay Hendrix Reed Jim Stuart Jr joyce Hendrix and I think the one on the left is Tom Bertelson Judy Hendrix Bertelsons son Janice James Kay, between Jim and Joyce is another lady, not sure who she is? Is that your Mom standing up? Then Tom on the right, Tom and Judy Bertelson's son! Thanks for your help! As you have time, will you check other pictures to see if I have them correct!", "HR78-018.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 69,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Hendrix brothers, Ed on left (Janice) and Bill (Stella)", "HR78-019.jpg", "HR78" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 70,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Kathy and Dennis Hendrix, Kathy holding Tacy, Tonya and Dennis holding Troy", "HR81-001.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 71,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "These are four of the Hendrix brothers; Chet, Oliver, Ed and Bill. Their brother Jim could not be there.", "HR81-002.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 72,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Mary (Mrs Harold) Hendrix with son David", "HR81-003.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 73,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "These are all Hendrix cousins! On the left of table are Donnie, Gary and Denny and right side are Harold and Dick!", "HR81-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 74,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Larry Hendrix, then-wife Rita, and daughter Michelle, with Chet Hendrix", "HR81-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 75,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR81-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 76,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Eddie (Hendrix) (Mrs Jim) Stuart and granddaughter Nicole Stuart", "HR81-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 77,
                columns: new[] { "Description", "FileName" },
                values: new object[] { " Hendrix cousins, Gary Hendrix and Kay (Hendrix) (Mrs Jack) Reed!", "HR81-008.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 78,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Pat (Hendrix) (Mrs Ron) Lease", "HR81-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 79,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Shirley (Hendrix) and Bob Morton.", "HR81-010.jpg", "HR81" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 80,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR81-011.jpg", "HR81" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 81,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Ed and Janice Hendrix family - Shirley, Kay, Eddie, Ed, Janice, Dick, Judy and Pat !", "HR81-012.jpg", "HR81" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 82,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR82-001.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 83,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR82-002.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 84,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR82-003.jpg", "HR82" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 85,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold Hendrix and Dick Hendrix, cousins", "HR84-001.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 86,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Sonny, Janice and their son Brad James", "HR84-002.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 87,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR84-003.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 88,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR84-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 89,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Gary Hendrix", "HR84-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 90,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR84-006.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 91,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "David Hendrix", "HR84-007.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 92,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR84-008.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 93,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR84-009.jpg", "HR84" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 94,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-001.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 95,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-002.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 96,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Linda (Hendrix) Burson", "HR85-003.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 97,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Linda (Hendrix) Burson", "HR85-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 98,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 99,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 100,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold Hendrix, Brad James", "HR85-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 101,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-008.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 102,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 103,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-010.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 104,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "David and Harold Hendrix, Larry Hendrix, Janice (Hendrix) James, Linda (Hendrix) Burson, Gary Hendrix", "HR85-011.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 105,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold Hendrix", "HR85-012.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 106,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Bill Hendrix", "HR85-013.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 107,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-014.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 108,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR85-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 109,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-016.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 110,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-017.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 111,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-018.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 112,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-019.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 113,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-020.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 114,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR85-021.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 115,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR85-022.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 116,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR85-023.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 117,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "no description", "HR85-024.jpg", "HR85" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 118,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-001.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 119,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-002.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 120,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-003.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 121,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-004.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 122,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-005.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 123,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Don Hendrix in back, son Darin, wife Marla, father Chet, mother Mildred and daughter's Darci and Deena", "HR86-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 124,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "no description", "HR86-007.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 125,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "back: Brad James, Gary Hendrix, Janice and Sonny James; front: Bill and Stella Hendrix, Harold Hendrix with David, Larry Hendrix with Erika and Jeremy", "HR86-008.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 126,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Jessie (Hendrix) Bethards", "HR86-009.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 127,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Uncle Jim and Aunt Mary Ann Hendrix", "HR86-010.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 128,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Aunt Mary Ann (Jim) Hendrix (back) and Janice James", "HR86-011.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 129,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Michelle (Hendrix) and Lonnie Dwyer", "HR86-012.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 130,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Brad, Sonny and Janice James", "HR86-013.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 131,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Harold and David Hendrix", "HR86-014.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 132,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Aunt Betty and Uncle Oliver Hendrix", "HR86-015.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 133,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Brothers, Chet, Oliver and Ed Hendrix", "HR86-016.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 134,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Ed and Janice Hendrix", "HR86-017.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 135,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Kathy and Dennis Hendrix and children Troy, Tacy and Tonya", "HR86-018.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 136,
                column: "FileName",
                value: "HR86-019.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 137,
                column: "FileName",
                value: "HR86-020.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 138,
                column: "FileName",
                value: "HR86-021.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 139,
                column: "FileName",
                value: "HR86-022.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 140,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Oliver, Jessie(Hendrix) Bethards, Jim, Bill and Chet. All Hendrix brothers and sister", "HR86-023.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 141,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Oliver, Jessie (Bethards) Hendrix, Jim, Bill and Chet. All Hendrix brothers and sister!", "HR86-024.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 142,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Janice (Hendrix) and Sonny James", "HR86-025.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 143,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Larry, Kellie, Mike, Jeremy and Erica Hendrix", "HR86-026.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 144,
                columns: new[] { "Description", "FileName" },
                values: new object[] { "Stella (Wood) and Bill Hendrix", "HR86-027.jpg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 145,
                column: "FileName",
                value: "HR86-028.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 146,
                column: "FileName",
                value: "HR86-029.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 147,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-030.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 148,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-031.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 149,
                columns: new[] { "Description", "FileName", "OccasionId" },
                values: new object[] { "Mike, Jeremy and Erica Hendrix", "HR86-032.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 150,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-033.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 151,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-034.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 152,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-035.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 153,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-036.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 154,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-037.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 155,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR86-038.jpg", "HR86" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 156,
                column: "FileName",
                value: "HR87-001.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 157,
                column: "FileName",
                value: "HR87-002.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 158,
                column: "FileName",
                value: "HR87-003.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 159,
                column: "FileName",
                value: "HR87-004.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 160,
                column: "FileName",
                value: "HR87-005.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 161,
                column: "FileName",
                value: "HR87-006.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 162,
                column: "FileName",
                value: "HR87-007.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 163,
                column: "FileName",
                value: "HR87-008.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 164,
                column: "FileName",
                value: "HR87-009.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 165,
                column: "FileName",
                value: "HR87-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 166,
                column: "FileName",
                value: "HR87-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 167,
                column: "FileName",
                value: "HR87-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 168,
                column: "FileName",
                value: "HR87-013.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 169,
                column: "FileName",
                value: "HR87-014.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 170,
                column: "FileName",
                value: "HR87-015.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 171,
                column: "FileName",
                value: "HR87-016.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 172,
                column: "FileName",
                value: "HR87-017.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 173,
                column: "FileName",
                value: "HR87-018.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 174,
                column: "FileName",
                value: "HR87-019.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 175,
                column: "FileName",
                value: "HR87-020.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 176,
                column: "FileName",
                value: "HR87-021.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 177,
                column: "FileName",
                value: "HR87-022.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 178,
                column: "FileName",
                value: "HR87-023.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 179,
                column: "FileName",
                value: "HR87-024.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 180,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-025.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 181,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-026.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 182,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-027.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 183,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-028.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 184,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-029.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 185,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-030.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 186,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-031.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 187,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-032.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 188,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR87-033.jpg", "HR87" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 189,
                column: "FileName",
                value: "HR88-001.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 190,
                column: "FileName",
                value: "HR88-002.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 191,
                column: "FileName",
                value: "HR88-003.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 192,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-004.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 193,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-005.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 194,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-006.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 195,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-007.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 196,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-008.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 197,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-009.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 198,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-010.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 199,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-011.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 200,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR88-012.jpg", "HR88" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 201,
                column: "FileName",
                value: "HR89-001.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 202,
                column: "FileName",
                value: "HR89-002.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 203,
                column: "FileName",
                value: "HR89-003.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 204,
                column: "FileName",
                value: "HR89-004.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 205,
                column: "FileName",
                value: "HR89-005.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 206,
                column: "FileName",
                value: "HR89-006.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 207,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-007.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 208,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-008.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 209,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-009.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 210,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-010.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 211,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-011.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 212,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-012.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 213,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-013.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 214,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-014.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 215,
                columns: new[] { "FileName", "OccasionId" },
                values: new object[] { "HR89-015.jpg", "HR89" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 216,
                column: "FileName",
                value: "HR90-001.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 217,
                column: "FileName",
                value: "HR90-002.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 218,
                column: "FileName",
                value: "HR90-003.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 219,
                column: "FileName",
                value: "HR90-004.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 220,
                column: "FileName",
                value: "HR90-005.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 221,
                column: "FileName",
                value: "HR90-006.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 222,
                column: "FileName",
                value: "HR90-007.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 223,
                column: "FileName",
                value: "HR90-008.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 224,
                column: "FileName",
                value: "HR90-009.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 225,
                column: "FileName",
                value: "HR90-010.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 226,
                column: "FileName",
                value: "HR90-011.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 227,
                column: "FileName",
                value: "HR90-012.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 228,
                column: "FileName",
                value: "HR90-013.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 229,
                column: "FileName",
                value: "HR90-014.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 230,
                column: "FileName",
                value: "HR90-015.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 231,
                column: "FileName",
                value: "HR90-016.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 232,
                column: "FileName",
                value: "HR90-017.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 233,
                column: "FileName",
                value: "HR90-018.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 234,
                column: "FileName",
                value: "HR90-019.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 235,
                column: "FileName",
                value: "HR90-020.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 236,
                column: "FileName",
                value: "HR90-021.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 237,
                column: "FileName",
                value: "HR90-022.jpg");

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[,]
                {
                    { 245, "no description", "HR90-030.jpg", "HR90", null },
                    { 239, "no description", "HR90-024.jpg", "HR90", null },
                    { 240, "no description", "HR90-025.jpg", "HR90", null },
                    { 241, "no description", "HR90-026.jpg", "HR90", null },
                    { 242, "no description", "HR90-027.jpg", "HR90", null },
                    { 243, "no description", "HR90-028.jpg", "HR90", null },
                    { 244, "no description", "HR90-029.jpg", "HR90", null },
                    { 246, "no description", "HR90-031.jpg", "HR90", null },
                    { 238, "no description", "HR90-023.jpg", "HR90", null }
                });
        }
    }
}
