using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaacsHotell.Data.Migrations
{
    public partial class fleranvändare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451089f0-da4s–5d6s-pqwe-59kmoldp78df6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451089f0-da4s–5d6s-pqwe-59kmoldp78df6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "Efternamn", "Email", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d9044c46-16c1-4c87-9e6e-a40f98927720", "Wagner", "Mrwagner@hotellet.se", "Karl", "mrwagner@HOTELLET.SE", "MRWAGNER@HOTELLET.SE", "AQAAAAEAACcQAAAAEFgcvcX1IMIBLwYx0dtUycq5JVrgvRL62gvqAPpkUHq/6s+/3kudhl6YVHsmwmrAaA==", "0713371337", "e6bd12f1-9e20-41bd-92b8-37601b51db96", "mrwagner@hotellet.se" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "Efternamn", "Email", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a62b0b32-4571-4e1b-8289-cb7862ae8182", "Ruskie", "Bernard@hotellet.se", "Bernard", "BERNARD@HOTELLET.SE", "BERNARD@HOTELLET.SE", "AQAAAAEAACcQAAAAEHLX5N/3dqWHPvjs9jK1ZqLTRqiiCU5gLzL5oKyTabv0XwaksUCpWjWauXlCZRwF8Q==", "763f5548-8f69-458f-8687-40300c45d1be", "Bernard@hotellet.se" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Efternamn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02123cf0–9652–4cde-afaf-59f706c72cf6", 0, "f2ed9692-f462-4b60-b35a-39568baa51f3", "Wagner", "Mrswagner@hotellet.se", true, false, null, "Amanda", "mrswagner@HOTELLET.SE", "MRSWAGNER@HOTELLET.SE", "AQAAAAEAACcQAAAAEOHNIAUDyqTZ2gvMxUEolfNNN8Un1W5uNEJtf2SjkfiqMAawyivIp8uh2MyL+2LjJg==", "0713371338", true, "c752f761-8e5b-446a-a336-d61a935d5c43", false, "mrswagner@hotellet.se" },
                    { "452349f0-da4s–5d6s-pqwe-59kmoldp78df6", 0, "72c4b304-c959-4ed3-890b-bb10b99f5ee7", "Algotsson", "Algot@hotellet.se", true, false, null, "Algot", "Algot@HOTELLET.SE", "ALGOT@HOTELLET.SE", "AQAAAAEAACcQAAAAEIKv9/Nz/YcxqtxqNM0A6zKY8jVO1oW3lj3VJfwizg3L1qkdNzF9t4Kkpfoa204zAQ==", "0784545884", true, "9426c766-3b9c-4c07-8910-424bc35b2bda", false, "Algot@hotellet.se" },
                    { "451029f0-da4s–5css-pawe-59kmolad21df6", 0, "86d884b9-c951-4c6e-a3ed-84cd5deee65b", "Beritsson", "Berit@hotellet.se", true, false, null, "Berit", "BERIT@HOTELLET.SE", "BERIT@HOTELLET.SE", "AQAAAAEAACcQAAAAEMwl3GLxnMO/F4gHJE5+JIRGWlYmI1quWizmboru17JhNGOlb6h6EgEP4+53xEMvNw==", "0784545884", true, "1facfd36-1abf-49ab-90da-2609531829be", false, "berit@hotellet.se" },
                    { "446929f0-dv2s–5csr-aawe-59ktylad21df6", 0, "c509c928-d8ae-4dce-8755-4d78eb834c6c", "Stark", "Ceasar@hotellet.se", true, false, null, "Ceasar", "Ceasar@HOTELLET.SE", "CEASAR@HOTELLET.SE", "AQAAAAEAACcQAAAAEJRSW/ZK9uKkiwrnUTUamNO71WA5KKn2i200iBixtlmEEXq5S8L6R18ecRG6t4OdgQ==", "0784545884", true, "c87cd9e8-e28f-4e28-a24e-cabcf7347502", false, "Ceasar@hotellet.se" },
                    { "569878f0-71bw–6hwq-qnmf-59dafgqg035f6", 0, "463d7644-1edf-4e22-8883-5fba1329ecbd", "Lotr", "Alva@hotellet.se", true, false, null, "Alva", "ALVA@HOTELLETS.SE", "ALVA@HOTELLETS.SE", "AQAAAAEAACcQAAAAEJGC2igOfXjYUcIbiOg0gertvtDJ0muqifp0UVCCPJbKtVdTOjluJaec4eKmvMG0Lg==", "0748612345", true, "91309744-1dc7-48d1-b60f-04165b43e4b3", false, "Alva@hotellet.se" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "02123cf0–9652–4cde-afaf-59f706c72cf6" },
                    { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "452349f0-da4s–5d6s-pqwe-59kmoldp78df6" },
                    { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451029f0-da4s–5css-pawe-59kmolad21df6" },
                    { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "446929f0-dv2s–5csr-aawe-59ktylad21df6" },
                    { "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "569878f0-71bw–6hwq-qnmf-59dafgqg035f6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "341743f0-asd2–42de-afbf-59kmkkmk72cf6", "02123cf0–9652–4cde-afaf-59f706c72cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "446929f0-dv2s–5csr-aawe-59ktylad21df6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451029f0-da4s–5css-pawe-59kmolad21df6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "452349f0-da4s–5d6s-pqwe-59kmoldp78df6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6", "569878f0-71bw–6hwq-qnmf-59dafgqg035f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02123cf0–9652–4cde-afaf-59f706c72cf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "446929f0-dv2s–5csr-aawe-59ktylad21df6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451029f0-da4s–5css-pawe-59kmolad21df6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452349f0-da4s–5d6s-pqwe-59kmoldp78df6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569878f0-71bw–6hwq-qnmf-59dafgqg035f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "Efternamn", "Email", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "438d97dd-5248-48be-9ac1-a52ad8bb5d73", "Ofoedu", "frankofoedu@gmail.com", "Frank", "FRANKOFOEDU@GMAIL.COM", "FRANKOFOEDU@GMAIL.COM", "AQAAAAEAACcQAAAAEJtDiy3JmqFlWQ0g63tFgKFKPneJGvjVFMtFKy9ytJ8sXddaQO8ZKPCvFQmBBTGu2w==", "0784545454", "19872282-8cb9-43b8-8c60-b05f093286ea", "frankofoedu@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569842f0-78dw–65ws-qwbf-59dafgqw345f6",
                columns: new[] { "ConcurrencyStamp", "Efternamn", "Email", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "088ff29f-f3e5-4a5c-9e9a-f0773b4175f9", "STÄD", "clean@gmail.com", "STÄD", "CLEAN@GMAIL.COM", "CLEAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOLIfziUxlgQMFZW/IOHEiLzO/2I0IIZmdR+0T8RXabXb8cuhV0nLZKZbxLNC67zTg==", "8ad8d3e6-f4f6-40f1-b7b4-664353153d26", "clean@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Efternamn", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Namn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "451089f0-da4s–5d6s-pqwe-59kmoldp78df6", 0, "cfcdad1b-4a03-42b3-b79f-3c924f7a2939", "Vodka", "Abosolut@gmail.com", true, false, null, "Absolut", "ABOSOLUT@GMAIL.COM", "ABSOLUT@GMAIL.COM", "AQAAAAEAACcQAAAAEGH/Xj40fuIzrGRT0v6TwVwHffCus2C2TiVft5wdFjYaHIG3I/dsOdcaU68Z0ezuSQ==", "0784545884", true, "0b161a29-2cbc-4e0a-b7b8-1adda4dd1b0e", false, "Abosolut@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "334567f0-whj2–47de-atyf-59qbvcse96cf6", "451089f0-da4s–5d6s-pqwe-59kmoldp78df6" });
        }
    }
}
