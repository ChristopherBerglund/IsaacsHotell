using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Migrations
{
    public partial class flergästervidstart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StädRapporter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rumettsmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumtvåsmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumtresmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumfyresmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumfemsmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumsexsmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumsjusmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumåttasmutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumniomutigt = table.Column<bool>(type: "bit", nullable: false),
                    Rumtiomutigt = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StädRapporter", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BokningId", "OrderId" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "Gäster",
                columns: new[] { "Id", "BokningId", "Efternamn", "Förnamn", "OrderId" },
                values: new object[,]
                {
                    { 2, null, "Wagner", "Amanda", null },
                    { 3, null, "Algotsson", "Algot", null },
                    { 4, null, "Beritsson", "Berit", null },
                    { 5, null, "Stark", "Ceasar", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StädRapporter");

            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Gäster",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BokningId", "OrderId" },
                values: new object[] { 1, 1 });
        }
    }
}
