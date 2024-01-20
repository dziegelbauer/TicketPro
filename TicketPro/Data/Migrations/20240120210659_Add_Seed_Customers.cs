using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Seed_Customers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "Name", "State", "StreetAddress", "Zip" },
                values: new object[,]
                {
                    { 1, "Sheboygan", "Rogers Steel", "MI", "123 Wasilla Way", "12345" },
                    { 2, "Toledo", "Brown Motors", "OH", "1042 Grand Avenue", "23456" },
                    { 3, "Big Spur", "Appliance Masters", "IN", "23 Highland Ridge Road", "34567" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
