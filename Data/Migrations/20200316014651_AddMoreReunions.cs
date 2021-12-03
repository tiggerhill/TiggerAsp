using Microsoft.EntityFrameworkCore.Migrations;

namespace TiggerAsp.Data.Migrations
{
    public partial class AddMoreReunions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "OccasionDescription", "OccasionName" },
                values: new object[,]
                {
                    { "HR68", "", "Hendrix Reunion, 1968" },
                    { "HR76", "", "Hendrix Reunion, 1976" },
                    { "HR77", "", "Hendrix Reunion, 1977" },
                    { "HR78", "", "Hendrix Reunion, 1978" },
                    { "HR81", "", "Hendrix Reunion, 1981" },
                    { "HR82", "", "Hendrix Reunion, 1982" },
                    { "HR84", "", "Hendrix Reunion, 1984" },
                    { "HR85", "", "Hendrix Reunion, 1985" },
                    { "HR86", "", "Hendrix Reunion, 1986" },
                    { "HR87", "", "Hendrix Reunion, 1987" },
                    { "HR88", "", "Hendrix Reunion, 1988" },
                    { "HR89", "", "Hendrix Reunion, 1989" },
                    { "HR90", "", "Hendrix Reunion, 1990" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR68");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR76");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR77");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR78");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR81");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR82");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR84");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR85");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR86");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR87");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR88");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR89");

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: "HR90");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
