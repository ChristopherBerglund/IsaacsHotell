using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class cleaneridentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "Cleaner", "CLEANER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d1c3237-6cee-4d3f-bcba-454db1997d06", "AQAAAAEAACcQAAAAEMBFxP35A97gQFKoPIvIdC8jUklYTfdBJiaYw2gDgYMOJeHnOidPhjLVJJkVxjYX/g==", "ecc15ef7-612f-4d6c-9373-922bcece2825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7219d6f3-9a07-434b-bb32-ab356d2c9f17", "AQAAAAEAACcQAAAAEEdTOSsn22KhTabav+FFCc0idq7/fNyzqk7jkAavKN2XE6EcOId3wenfJIe0lYYD1Q==", "824274d5-1c8f-4d4a-8c0f-e5fc4bd69497" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Efternamn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "569842f0-78dw–65ws-qwbf-59dafgqw345f6", 0, "f3ad8e9d-288b-4572-8a80-cc943fa979aa", "STÄD", "städ@gmail.com", true, false, null, "STÄD", "STÄD@GMAIL.COM", "STÄD@GMAIL.COM", null, "0748612345", true, "a243c616-351c-4851-b8be-f2a27f843972", false, "Städ@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "569842f0-78dw–65ws-qwbf-59dafgqw345f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "569842f0-78dw–65ws-qwbf-59dafgqw345f6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ae8a75-e7e2-4273-8fa8-8c18760c4f35", "AQAAAAEAACcQAAAAEHDo1z06zL9fVbsRd59ZK+DD7pmjy/itWlOXArODQKQPmdgQLXF6GrwQF4aI73t6SQ==", "bd6fe9bc-841b-4531-aeae-ef557519cfd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89292667-27a1-4485-8442-3c84c5713b34", "AQAAAAEAACcQAAAAEN8eNBeqVmQE+lCSh7RZn6vnrK5ZVkC7yX1ZIbDJImsxJ2eDJy8r1ZJwFKAzRu7kDg==", "820e4587-5e92-4704-88a8-1ae5d01eb7d8" });
        }
    }
}
