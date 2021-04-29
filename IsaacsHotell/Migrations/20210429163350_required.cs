using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Migrations
{
    public partial class required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "Rum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Produkt",
                table: "Ordrar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Förnamn",
                table: "Gäster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Efternamn",
                table: "Gäster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Anställda",
                keyColumn: "Id",
                keyValue: 1,
                column: "Efternamn",
                value: "Wagner");

            migrationBuilder.UpdateData(
                table: "Anställda",
                keyColumn: "Id",
                keyValue: 2,
                column: "Efternamn",
                value: "Wagner");

            migrationBuilder.UpdateData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Efternamn", "Förnamn" },
                values: new object[] { "Wagner", "Karl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "Rum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Produkt",
                table: "Ordrar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Förnamn",
                table: "Gäster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Efternamn",
                table: "Gäster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Anställda",
                keyColumn: "Id",
                keyValue: 1,
                column: "Efternamn",
                value: "Anka");

            migrationBuilder.UpdateData(
                table: "Anställda",
                keyColumn: "Id",
                keyValue: 2,
                column: "Efternamn",
                value: "Bengtsson");

            migrationBuilder.UpdateData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Efternamn", "Förnamn" },
                values: new object[] { "Aronsson", "Alf" });
        }
    }
}
