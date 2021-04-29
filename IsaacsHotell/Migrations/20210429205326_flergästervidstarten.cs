using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Migrations
{
    public partial class flergästervidstarten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gäster",
                columns: new[] { "Id", "BokningId", "Efternamn", "Förnamn", "OrderId" },
                values: new object[] { 6, null, "Lotr", "Alva", null });

            migrationBuilder.InsertData(
                table: "Gäster",
                columns: new[] { "Id", "BokningId", "Efternamn", "Förnamn", "OrderId" },
                values: new object[] { 7, null, "Ruskie", "Bernard", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
