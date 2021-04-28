using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class cleanerusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "438d97dd-5248-48be-9ac1-a52ad8bb5d73", "AQAAAAEAACcQAAAAEJtDiy3JmqFlWQ0g63tFgKFKPneJGvjVFMtFKy9ytJ8sXddaQO8ZKPCvFQmBBTGu2w==", "19872282-8cb9-43b8-8c60-b05f093286ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfcdad1b-4a03-42b3-b79f-3c924f7a2939", "AQAAAAEAACcQAAAAEGH/Xj40fuIzrGRT0v6TwVwHffCus2C2TiVft5wdFjYaHIG3I/dsOdcaU68Z0ezuSQ==", "0b161a29-2cbc-4e0a-b7b8-1adda4dd1b0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "088ff29f-f3e5-4a5c-9e9a-f0773b4175f9", "clean@gmail.com", "CLEAN@GMAIL.COM", "CLEAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOLIfziUxlgQMFZW/IOHEiLzO/2I0IIZmdR+0T8RXabXb8cuhV0nLZKZbxLNC67zTg==", "8ad8d3e6-f4f6-40f1-b7b4-664353153d26", "clean@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6a9b5cb8-8463-4060-b1bb-9896977ffd6a", "städ@gmail.com", "STÄD@GMAIL.COM", "STÄD@GMAIL.COM", "AQAAAAEAACcQAAAAELHjP5F9Cl6ivRzFdvWEyonqEfjKDmO8OrnPHO8Xh5SgxnnALuPm3XZgPegnq5M+Hw==", "d7824aef-098d-4659-9745-e53aa1751ffe", "Städ" });
        }
    }
}
