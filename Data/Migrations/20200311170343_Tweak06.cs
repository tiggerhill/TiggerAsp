using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class Tweak06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Comments_Members_MemberId",
        //        table: "Comments");

        //    migrationBuilder.DropTable(
        //        name: "Members");

        //    migrationBuilder.AlterColumn<string>(
        //        name: "MemberId",
        //        table: "Comments",
        //        nullable: true,
        //        oldClrType: typeof(int),
        //        oldType: "int",
        //        oldNullable: true);

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Comments_AspNetUsers_MemberId",
        //        table: "Comments",
        //        column: "MemberId",
        //        principalTable: "AspNetUsers",
        //        principalColumn: "Id",
        //        onDelete: ReferentialAction.Restrict);
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Comments_AspNetUsers_MemberId",
        //        table: "Comments");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "MemberId",
        //        table: "Comments",
        //        type: "int",
        //        nullable: true,
        //        oldClrType: typeof(string),
        //        oldNullable: true);

        //    migrationBuilder.CreateTable(
        //        name: "Members",
        //        columns: table => new
        //        {
        //            MemberId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            MemberName = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Members", x => x.MemberId);
        //        });

        //    migrationBuilder.InsertData(
        //        table: "Members",
        //        columns: new[] { "MemberId", "MemberName" },
        //        values: new object[] { 1, "Tony Hendrix-Hill" });

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Comments_Members_MemberId",
        //        table: "Comments",
        //        column: "MemberId",
        //        principalTable: "Members",
        //        principalColumn: "MemberId",
        //        onDelete: ReferentialAction.Restrict);
        }
    }
}
