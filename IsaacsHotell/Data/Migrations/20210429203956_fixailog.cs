using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class fixailog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Efternamn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02123cf0–9652–4cde-afaf-59f706c72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "844192c7-dd28-43fe-888e-b4afc9058469", "AQAAAAEAACcQAAAAEIvw0lmDMKtjUFcZnuGLA3XczfRFdWPdXlpZk/2keakD7rdE43swrHKpLCQkmI0oAw==", "a85c2e51-493d-47a9-9113-58fcbac15ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6c2e2af-3e13-4db2-b0a2-807916b11e7d", "AQAAAAEAACcQAAAAENsa/U3zKPgICRh/07UHPKjmpoD4i85b89tylDnG2sPlnCR0eLKnCnYiNhVingLQqg==", "b91e57b5-1d31-4381-ba69-472f51fb8e58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "446929f0-dv2s–5csr-aawe-59ktylad21df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aade405-2a4d-44ce-83ef-56102082bbc3", "AQAAAAEAACcQAAAAEPlfwXHepdeHlT4y1AQ23n0PtegYIwT+xiYKwHJLNCuHYl+xYIHkDqizrVeD9NbmrA==", "c4ab96be-9544-4193-bd1c-f3dc37c3d29c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451029f0-da4s–5css-pawe-59kmolad21df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66a5ba3c-d6c1-47aa-9f32-64320a117401", "AQAAAAEAACcQAAAAEDa3N2NUj66+g8AewSVHyRipx3plxn8fqJviaMn/KbcWeV17TVT/7iOGhQmhFxs/Dw==", "f6d5d711-3bb2-4e5b-b8a6-9eae812aa448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452349f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f5d786-0ee6-4c28-9b3e-d49b6cbe1245", "AQAAAAEAACcQAAAAEME8F0R0VRwr6YSkZI0MSRO19uM6mX7cTn/62w3KFaV5rbX2nAjKB4nIkRm9palusg==", "27af47f0-66e1-420c-9a6a-a606f5aa93a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3634320-b335-4a54-9374-30f2821a2d35", "AQAAAAEAACcQAAAAEMsequRs+RBJoZu83U4N4uH/kF8aay2c6ebsrM+FWmAHkU203a1S5dqFpnw7DwcjDw==", "e6c654cb-261b-4e53-8e63-7759814a41cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569878f0-71bw–6hwq-qnmf-59dafgqg035f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aafff35-1a07-4265-a617-ca684b7d98c6", "ALVA@HOTELLET.SE", "ALVA@HOTELLET.SE", "AQAAAAEAACcQAAAAEMJufgbQcNjrCXl2vvl8kOplqxadMz6oXExkFkyTNHTttIEsrcyCSfrtArU6bOXu1Q==", "749c4ed3-982a-4355-931e-7ad5deb7b772" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Namn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Efternamn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02123cf0–9652–4cde-afaf-59f706c72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2ed9692-f462-4b60-b35a-39568baa51f3", "AQAAAAEAACcQAAAAEOHNIAUDyqTZ2gvMxUEolfNNN8Un1W5uNEJtf2SjkfiqMAawyivIp8uh2MyL+2LjJg==", "c752f761-8e5b-446a-a336-d61a935d5c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9044c46-16c1-4c87-9e6e-a40f98927720", "AQAAAAEAACcQAAAAEFgcvcX1IMIBLwYx0dtUycq5JVrgvRL62gvqAPpkUHq/6s+/3kudhl6YVHsmwmrAaA==", "e6bd12f1-9e20-41bd-92b8-37601b51db96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "446929f0-dv2s–5csr-aawe-59ktylad21df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c509c928-d8ae-4dce-8755-4d78eb834c6c", "AQAAAAEAACcQAAAAEJRSW/ZK9uKkiwrnUTUamNO71WA5KKn2i200iBixtlmEEXq5S8L6R18ecRG6t4OdgQ==", "c87cd9e8-e28f-4e28-a24e-cabcf7347502" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451029f0-da4s–5css-pawe-59kmolad21df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d884b9-c951-4c6e-a3ed-84cd5deee65b", "AQAAAAEAACcQAAAAEMwl3GLxnMO/F4gHJE5+JIRGWlYmI1quWizmboru17JhNGOlb6h6EgEP4+53xEMvNw==", "1facfd36-1abf-49ab-90da-2609531829be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452349f0-da4s–5d6s-pqwe-59kmoldp78df6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c4b304-c959-4ed3-890b-bb10b99f5ee7", "AQAAAAEAACcQAAAAEIKv9/Nz/YcxqtxqNM0A6zKY8jVO1oW3lj3VJfwizg3L1qkdNzF9t4Kkpfoa204zAQ==", "9426c766-3b9c-4c07-8910-424bc35b2bda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62b0b32-4571-4e1b-8289-cb7862ae8182", "AQAAAAEAACcQAAAAEHLX5N/3dqWHPvjs9jK1ZqLTRqiiCU5gLzL5oKyTabv0XwaksUCpWjWauXlCZRwF8Q==", "763f5548-8f69-458f-8687-40300c45d1be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569878f0-71bw–6hwq-qnmf-59dafgqg035f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "463d7644-1edf-4e22-8883-5fba1329ecbd", "ALVA@HOTELLETS.SE", "ALVA@HOTELLETS.SE", "AQAAAAEAACcQAAAAEJGC2igOfXjYUcIbiOg0gertvtDJ0muqifp0UVCCPJbKtVdTOjluJaec4eKmvMG0Lg==", "91309744-1dc7-48d1-b60f-04165b43e4b3" });
        }
    }
}
