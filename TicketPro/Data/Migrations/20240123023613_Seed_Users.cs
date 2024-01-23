using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "104B3E6E-74E7-4CD5-B3BD-2D5567AE4101",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD",
                column: "NormalizedName",
                value: "MANAGER");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A83849D4-4393-4930-9C1A-319AA1572F59",
                column: "NormalizedName",
                value: "EXECUTIVE");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7",
                column: "NormalizedName",
                value: "TECHNICIAN");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ChargeableRate", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3aca033f-f48d-4a76-ba7c-ac58c629a7ec", 0, 0m, "7edac54f-7633-49b3-8c90-16d35ef60d78", "sjackson@lfrc.com", true, true, null, "SJACKSON@LFRC.COM", "SJACKSON@LFRC.COM", "AQAAAAIAAYagAAAAEA0BPAhDLT/LEHuJKiiaJf3BLfFUXqifp5DPoT5RdDZRMRg9mbTSKxqX3sSJkPjqcA==", null, false, "EJGQIJIGPYKWNJSP2LHJZH47HK4NGRPJ", false, "sjackson@lfrc.com" },
                    { "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 0, 100.00m, "d3bf6453-5611-4846-ad5b-083dac66b928", "dhart@lfrc.com", true, true, null, "DHART@LFRC.COM", "DHART@LFRC.COM", "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==", null, false, "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7", false, "dhart@lfrc.com" },
                    { "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, 250.00m, "b1620237-28ff-4aef-b536-acb35ee49e4f", "cdurbin@lfrc.com", true, true, null, "CDURBIN@LFRC.COM", "CDURBIN@LFRC.COM", "AQAAAAIAAYagAAAAEC8zLHn4ZizET8ultmwR/nf14f4csdC0hr1NWDuwm9nHzamGBnZ1tlBd1LCtkmPaww==", null, false, "5UMDLZ7ACFLFMOA637F2ZYXGTLUFY6G2", false, "cdurbin@lfrc.com" },
                    { "ecb59549-4167-4315-a89f-2bf998b1c289", 0, 0m, "dcb52449-7275-42ad-baea-3213d588c2be", "mshoreheim@lfrc.com", true, true, null, "MSHOREHEIM@LFRC.COM", "MSHOREHEIM@LFRC.COM", "AQAAAAIAAYagAAAAEO2wfiod2bMvxEqkDwbnFM88xtPo2gOSM0KrJ5nJJ4M38Dnx1Qk2WoXKiLPVpOF/ww==", null, false, "YS2QTXJ5CFFBKWKIVRJVQTDVCS6ZARIU", false, "mshoreheim@lfrc.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aca033f-f48d-4a76-ba7c-ac58c629a7ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cf1351a-f2b6-4504-8d22-25b3dd5437e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afcd7a50-a4f1-4a5f-831c-94b945f10371");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecb59549-4167-4315-a89f-2bf998b1c289");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "104B3E6E-74E7-4CD5-B3BD-2D5567AE4101",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A83849D4-4393-4930-9C1A-319AA1572F59",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7",
                column: "NormalizedName",
                value: null);
        }
    }
}
