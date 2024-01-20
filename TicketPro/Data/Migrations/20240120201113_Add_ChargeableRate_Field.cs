using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_ChargeableRate_Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ChargeableRate",
                table: "AspNetUsers",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "104B3E6E-74E7-4CD5-B3BD-2D5567AE4101", null, "Admin", null },
                    { "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD", null, "Manager", null },
                    { "A83849D4-4393-4930-9C1A-319AA1572F59", null, "Executive", null },
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", null, "Technician", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "104B3E6E-74E7-4CD5-B3BD-2D5567AE4101");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A83849D4-4393-4930-9C1A-319AA1572F59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7");

            migrationBuilder.DropColumn(
                name: "ChargeableRate",
                table: "AspNetUsers");
        }
    }
}
