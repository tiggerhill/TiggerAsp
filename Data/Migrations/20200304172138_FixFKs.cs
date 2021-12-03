using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class FixFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentMember",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentPhoto",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentMemberId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentPhotoId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "CommentMemberId", "CommentPhotoId" },
                values: new object[] { 1, 9 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MemberId",
                table: "Comments",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PhotoId",
                table: "Comments",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Members_MemberId",
                table: "Comments",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Photos_PhotoId",
                table: "Comments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Members_MemberId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Photos_PhotoId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MemberId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PhotoId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentMemberId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentPhotoId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentMember",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentPhoto",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "CommentMember", "CommentPhoto" },
                values: new object[] { 1, 9 });
        }
    }
}
