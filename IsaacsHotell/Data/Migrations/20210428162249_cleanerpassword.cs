using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class cleanerpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08afffc4-7805-4ade-b507-a22d90e5e85a", "AQAAAAEAACcQAAAAECT2ZX754qPXkRYzAwfS8qwKVM04bIaF+NGE/cYDVZNTLUhFxlLfnC/SaVLOpmHXwA==", "430cc0e2-b840-46e9-af52-989ca1eb130a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8c7241d-eceb-4438-b849-85a65e2ea8b1", "AQAAAAEAACcQAAAAEPFvsIT/wHQimNANEKQuZPyVnSvc8ijkmYjNVC7OPKh54rqQktkScSv6UQjwBD6eOg==", "0e4996d3-01be-47ef-89a2-eb396c69a112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6a9b5cb8-8463-4060-b1bb-9896977ffd6a", "AQAAAAEAACcQAAAAELHjP5F9Cl6ivRzFdvWEyonqEfjKDmO8OrnPHO8Xh5SgxnnALuPm3XZgPegnq5M+Hw==", "d7824aef-098d-4659-9745-e53aa1751ffe", "Städ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f3ad8e9d-288b-4572-8a80-cc943fa979aa", null, "a243c616-351c-4851-b8be-f2a27f843972", "Städ@gmail.com" });
        }
    }
}
