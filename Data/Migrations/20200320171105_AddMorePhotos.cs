using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class AddMorePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 10);

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

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[,]
                {
                    { 245, "no description", "HR90-030.jpg", "HR90", null },
                    { 188, "no description", "HR87-033.jpg", "HR87", null },
                    { 189, "no description", "HR88-001.jpg", "HR88", null },
                    { 190, "no description", "HR88-002.jpg", "HR88", null },
                    { 191, "no description", "HR88-003.jpg", "HR88", null },
                    { 192, "no description", "HR88-004.jpg", "HR88", null },
                    { 193, "no description", "HR88-005.jpg", "HR88", null },
                    { 194, "no description", "HR88-006.jpg", "HR88", null },
                    { 187, "no description", "HR87-032.jpg", "HR87", null },
                    { 195, "no description", "HR88-007.jpg", "HR88", null },
                    { 197, "no description", "HR88-009.jpg", "HR88", null },
                    { 198, "no description", "HR88-010.jpg", "HR88", null },
                    { 199, "no description", "HR88-011.jpg", "HR88", null },
                    { 200, "no description", "HR88-012.jpg", "HR88", null },
                    { 201, "no description", "HR89-001.jpg", "HR89", null },
                    { 202, "no description", "HR89-002.jpg", "HR89", null },
                    { 203, "no description", "HR89-003.jpg", "HR89", null },
                    { 196, "no description", "HR88-008.jpg", "HR88", null },
                    { 186, "no description", "HR87-031.jpg", "HR87", null },
                    { 185, "no description", "HR87-030.jpg", "HR87", null },
                    { 184, "no description", "HR87-029.jpg", "HR87", null },
                    { 167, "no description", "HR87-012.jpg", "HR87", null },
                    { 168, "no description", "HR87-013.jpg", "HR87", null },
                    { 169, "no description", "HR87-014.jpg", "HR87", null },
                    { 170, "no description", "HR87-015.jpg", "HR87", null },
                    { 171, "no description", "HR87-016.jpg", "HR87", null },
                    { 172, "no description", "HR87-017.jpg", "HR87", null },
                    { 173, "no description", "HR87-018.jpg", "HR87", null },
                    { 174, "no description", "HR87-019.jpg", "HR87", null },
                    { 175, "no description", "HR87-020.jpg", "HR87", null },
                    { 176, "no description", "HR87-021.jpg", "HR87", null },
                    { 177, "no description", "HR87-022.jpg", "HR87", null },
                    { 178, "no description", "HR87-023.jpg", "HR87", null },
                    { 179, "no description", "HR87-024.jpg", "HR87", null },
                    { 180, "no description", "HR87-025.jpg", "HR87", null },
                    { 181, "no description", "HR87-026.jpg", "HR87", null },
                    { 182, "no description", "HR87-027.jpg", "HR87", null },
                    { 183, "no description", "HR87-028.jpg", "HR87", null },
                    { 204, "no description", "HR89-004.jpg", "HR89", null },
                    { 246, "no description", "HR90-031.jpg", "HR90", null },
                    { 205, "no description", "HR89-005.jpg", "HR89", null },
                    { 207, "no description", "HR89-007.jpg", "HR89", null },
                    { 229, "no description", "HR90-014.jpg", "HR90", null },
                    { 230, "no description", "HR90-015.jpg", "HR90", null },
                    { 231, "no description", "HR90-016.jpg", "HR90", null },
                    { 232, "no description", "HR90-017.jpg", "HR90", null },
                    { 233, "no description", "HR90-018.jpg", "HR90", null },
                    { 234, "no description", "HR90-019.jpg", "HR90", null },
                    { 235, "no description", "HR90-020.jpg", "HR90", null },
                    { 228, "no description", "HR90-013.jpg", "HR90", null },
                    { 236, "no description", "HR90-021.jpg", "HR90", null },
                    { 238, "no description", "HR90-023.jpg", "HR90", null },
                    { 239, "no description", "HR90-024.jpg", "HR90", null },
                    { 240, "no description", "HR90-025.jpg", "HR90", null },
                    { 241, "no description", "HR90-026.jpg", "HR90", null },
                    { 242, "no description", "HR90-027.jpg", "HR90", null },
                    { 243, "no description", "HR90-028.jpg", "HR90", null },
                    { 244, "no description", "HR90-029.jpg", "HR90", null },
                    { 237, "no description", "HR90-022.jpg", "HR90", null },
                    { 227, "no description", "HR90-012.jpg", "HR90", null },
                    { 226, "no description", "HR90-011.jpg", "HR90", null },
                    { 225, "no description", "HR90-010.jpg", "HR90", null },
                    { 208, "no description", "HR89-008.jpg", "HR89", null },
                    { 209, "no description", "HR89-009.jpg", "HR89", null },
                    { 210, "no description", "HR89-010.jpg", "HR89", null },
                    { 211, "no description", "HR89-011.jpg", "HR89", null },
                    { 212, "no description", "HR89-012.jpg", "HR89", null },
                    { 213, "no description", "HR89-013.jpg", "HR89", null },
                    { 214, "no description", "HR89-014.jpg", "HR89", null },
                    { 215, "no description", "HR89-015.jpg", "HR89", null },
                    { 216, "no description", "HR90-001.jpg", "HR90", null },
                    { 217, "no description", "HR90-002.jpg", "HR90", null },
                    { 218, "no description", "HR90-003.jpg", "HR90", null },
                    { 219, "no description", "HR90-004.jpg", "HR90", null },
                    { 220, "no description", "HR90-005.jpg", "HR90", null },
                    { 221, "no description", "HR90-006.jpg", "HR90", null },
                    { 222, "no description", "HR90-007.jpg", "HR90", null },
                    { 223, "no description", "HR90-008.jpg", "HR90", null },
                    { 224, "no description", "HR90-009.jpg", "HR90", null },
                    { 166, "no description", "HR87-011.jpg", "HR87", null },
                    { 206, "no description", "HR89-006.jpg", "HR89", null },
                    { 165, "no description", "HR87-010.jpg", "HR87", null },
                    { 163, "no description", "HR87-008.jpg", "HR87", null },
                    { 104, "David and Harold Hendrix, Larry Hendrix, Janice (Hendrix) James, Linda (Hendrix) Burson, Gary Hendrix", "HR85-011.jpg", "HR85", null },
                    { 105, "Harold Hendrix", "HR85-012.jpg", "HR85", null },
                    { 106, "Bill Hendrix", "HR85-013.jpg", "HR85", null },
                    { 107, "no description", "HR85-014.jpg", "HR85", null },
                    { 108, "no description", "HR85-015.jpg", "HR85", null },
                    { 109, "no description", "HR85-016.jpg", "HR85", null },
                    { 110, "no description", "HR85-017.jpg", "HR85", null },
                    { 111, "no description", "HR85-018.jpg", "HR85", null },
                    { 112, "no description", "HR85-019.jpg", "HR85", null },
                    { 113, "no description", "HR85-020.jpg", "HR85", null },
                    { 114, "no description", "HR85-021.jpg", "HR85", null },
                    { 115, "no description", "HR85-022.jpg", "HR85", null },
                    { 116, "no description", "HR85-023.jpg", "HR85", null },
                    { 117, "no description", "HR85-024.jpg", "HR85", null },
                    { 118, "no description", "HR86-001.jpg", "HR86", null },
                    { 119, "no description", "HR86-002.jpg", "HR86", null },
                    { 120, "no description", "HR86-003.jpg", "HR86", null },
                    { 103, "no description", "HR85-010.jpg", "HR85", null },
                    { 121, "no description", "HR86-004.jpg", "HR86", null },
                    { 102, "no description", "HR85-009.jpg", "HR85", null },
                    { 100, "Harold Hendrix, Brad James", "HR85-007.jpg", "HR85", null },
                    { 83, "no description", "HR82-002.jpg", "HR82", null },
                    { 84, "no description", "HR82-003.jpg", "HR82", null },
                    { 85, "Harold Hendrix and Dick Hendrix, cousins", "HR84-001.jpg", "HR84", null },
                    { 86, "Sonny, Janice and their son Brad James", "HR84-002.jpg", "HR84", null },
                    { 87, "no description", "HR84-003.jpg", "HR84", null },
                    { 88, "no description", "HR84-004.jpg", "HR84", null },
                    { 89, "Gary Hendrix", "HR84-005.jpg", "HR84", null },
                    { 90, "no description", "HR84-006.jpg", "HR84", null },
                    { 91, "David Hendrix", "HR84-007.jpg", "HR84", null },
                    { 92, "no description", "HR84-008.jpg", "HR84", null },
                    { 93, "no description", "HR84-009.jpg", "HR84", null },
                    { 94, "no description", "HR85-001.jpg", "HR85", null },
                    { 95, "no description", "HR85-002.jpg", "HR85", null },
                    { 96, "Linda (Hendrix) Burson", "HR85-003.jpg", "HR85", null },
                    { 97, "Linda (Hendrix) Burson", "HR85-004.jpg", "HR85", null },
                    { 98, "no description", "HR85-005.jpg", "HR85", null },
                    { 99, "no description", "HR85-006.jpg", "HR85", null },
                    { 101, "no description", "HR85-008.jpg", "HR85", null },
                    { 164, "no description", "HR87-009.jpg", "HR87", null },
                    { 122, "no description", "HR86-005.jpg", "HR86", null },
                    { 124, "no description", "HR86-007.jpg", "HR86", null },
                    { 146, "no description", "HR86-029.jpg", "HR86", null },
                    { 147, "no description", "HR86-030.jpg", "HR86", null },
                    { 148, "no description", "HR86-031.jpg", "HR86", null },
                    { 149, "Mike, Jeremy and Erica Hendrix", "HR86-032.jpg", "HR86", null },
                    { 150, "no description", "HR86-033.jpg", "HR86", null },
                    { 151, "no description", "HR86-034.jpg", "HR86", null },
                    { 152, "no description", "HR86-035.jpg", "HR86", null },
                    { 153, "no description", "HR86-036.jpg", "HR86", null },
                    { 154, "no description", "HR86-037.jpg", "HR86", null },
                    { 155, "no description", "HR86-038.jpg", "HR86", null },
                    { 156, "no description", "HR87-001.jpg", "HR87", null },
                    { 157, "no description", "HR87-002.jpg", "HR87", null },
                    { 158, "no description", "HR87-003.jpg", "HR87", null },
                    { 159, "no description", "HR87-004.jpg", "HR87", null },
                    { 160, "no description", "HR87-005.jpg", "HR87", null },
                    { 161, "no description", "HR87-006.jpg", "HR87", null },
                    { 162, "no description", "HR87-007.jpg", "HR87", null },
                    { 145, "no description", "HR86-028.jpg", "HR86", null },
                    { 123, "Don Hendrix in back, son Darin, wife Marla, father Chet, mother Mildred and daughter's Darci and Deena", "HR86-006.jpg", "HR86", null },
                    { 144, "Stella (Wood) and Bill Hendrix", "HR86-027.jpg", "HR86", null },
                    { 142, "Janice (Hendrix) and Sonny James", "HR86-025.jpg", "HR86", null },
                    { 125, "back: Brad James, Gary Hendrix, Janice and Sonny James; front: Bill and Stella Hendrix, Harold Hendrix with David, Larry Hendrix with Erika and Jeremy", "HR86-008.jpg", "HR86", null },
                    { 126, "Jessie (Hendrix) Bethards", "HR86-009.jpg", "HR86", null },
                    { 127, "Uncle Jim and Aunt Mary Ann Hendrix", "HR86-010.jpg", "HR86", null },
                    { 128, "Aunt Mary Ann (Jim) Hendrix (back) and Janice James", "HR86-011.jpg", "HR86", null },
                    { 129, "Michelle (Hendrix) and Lonnie Dwyer", "HR86-012.jpg", "HR86", null },
                    { 130, "Brad, Sonny and Janice James", "HR86-013.jpg", "HR86", null },
                    { 131, "Harold and David Hendrix", "HR86-014.jpg", "HR86", null },
                    { 132, "Aunt Betty and Uncle Oliver Hendrix", "HR86-015.jpg", "HR86", null },
                    { 133, "Brothers, Chet, Oliver and Ed Hendrix", "HR86-016.jpg", "HR86", null },
                    { 134, "Ed and Janice Hendrix", "HR86-017.jpg", "HR86", null },
                    { 135, "Kathy and Dennis Hendrix and children Troy, Tacy and Tonya", "HR86-018.jpg", "HR86", null },
                    { 136, "no description", "HR86-019.jpg", "HR86", null },
                    { 137, "no description", "HR86-020.jpg", "HR86", null },
                    { 138, "no description", "HR86-021.jpg", "HR86", null },
                    { 139, "no description", "HR86-022.jpg", "HR86", null },
                    { 140, "Oliver, Jessie(Hendrix) Bethards, Jim, Bill and Chet. All Hendrix brothers and sister", "HR86-023.jpg", "HR86", null },
                    { 141, "Oliver, Jessie (Bethards) Hendrix, Jim, Bill and Chet. All Hendrix brothers and sister!", "HR86-024.jpg", "HR86", null },
                    { 143, "Larry, Kellie, Mike, Jeremy and Erica Hendrix", "HR86-026.jpg", "HR86", null },
                    { 82, "no description", "HR82-001.jpg", "HR82", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 237);

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
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 6,
                column: "Description",
                value: " Elisha and Orpha (Hazlett) Hendrix's sons. Chet standing on top of hay, Ed on left and Oliver, putting up hay on Chet's farm at Leon, Iowa in 1943..");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 9,
                column: "Description",
                value: "Written by Stella (Wood) Hendrix.");

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Description", "FileName", "OccasionId", "UploadedBy" },
                values: new object[] { 10, "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Bill, Chet, Ed. Middle, Ruby, Jessie and Elisha; Front, Oliver and Jim.", "EH-001downsizedframed.jpg", "00", null });
        }
    }
}
