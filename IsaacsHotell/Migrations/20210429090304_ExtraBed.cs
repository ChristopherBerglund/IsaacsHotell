using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Migrations
{
    public partial class ExtraBed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ExtraSäng",
                table: "Bokningar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraSäng",
                table: "Bokningar");
        }
    }
}
