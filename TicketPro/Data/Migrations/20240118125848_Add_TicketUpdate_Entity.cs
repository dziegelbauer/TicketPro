using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_TicketUpdate_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketUpdates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Note = table.Column<string>(type: "text", nullable: false),
                    IsResolution = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Timestamp = table.Column<byte[]>(type: "bytea", nullable: true),
                    TicketId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketUpdates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketUpdates_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TicketUpdates_AspNetUsers_ModifierId",
                        column: x => x.ModifierId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TicketUpdates_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketUpdates_CreatorId",
                table: "TicketUpdates",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketUpdates_ModifierId",
                table: "TicketUpdates",
                column: "ModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketUpdates_TicketId",
                table: "TicketUpdates",
                column: "TicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketUpdates");
        }
    }
}
