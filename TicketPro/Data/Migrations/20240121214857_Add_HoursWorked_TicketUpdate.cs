﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_HoursWorked_TicketUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HoursWorked",
                table: "TicketUpdates",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "TicketUpdates");
        }
    }
}