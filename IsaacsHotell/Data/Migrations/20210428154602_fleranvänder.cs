using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class fleranvänder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "334567f0-whj2–47de-atyf-59qbvcse96cf6", "Reception", "RECEPTION" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ae8a75-e7e2-4273-8fa8-8c18760c4f35", "AQAAAAEAACcQAAAAEHDo1z06zL9fVbsRd59ZK+DD7pmjy/itWlOXArODQKQPmdgQLXF6GrwQF4aI73t6SQ==", "bd6fe9bc-841b-4531-aeae-ef557519cfd0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Efternamn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "451089f0-da4s–5d6s-pqwe-59kmoldp78df6", 0, "89292667-27a1-4485-8442-3c84c5713b34", "Vodka", "Abosolut@gmail.com", true, false, null, "Absolut", "ABOSOLUT@GMAIL.COM", "ABSOLUT@GMAIL.COM", "AQAAAAEAACcQAAAAEN8eNBeqVmQE+lCSh7RZn6vnrK5ZVkC7yX1ZIbDJImsxJ2eDJy8r1ZJwFKAzRu7kDg==", "0784545884", true, "820e4587-5e92-4704-88a8-1ae5d01eb7d8", false, "Abosolut@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451089f0-da4s–5d6s-pqwe-59kmoldp78df6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451089f0-da4s–5d6s-pqwe-59kmoldp78df6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334567f0-whj2–47de-atyf-59qbvcse96cf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48e16ac2-b702-4022-8cd9-a17bacc7d737", "AQAAAAEAACcQAAAAEDQB/3gFwkIV08pNh3zE9IMxG0rizpZ3J/1qsaeecwFB1gyyewtNDd3+/YulKclzAQ==", "2f5ac44a-1b35-4d82-93cb-2ad3f5fb8136" });
        }
    }
}
