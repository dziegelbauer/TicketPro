using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Tickets",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Tickets",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Closed",
                table: "Tickets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ChargeableRate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "398d1dda-bc39-4208-b358-f888bfbb2ee9", 0, 180.00m, "d3bf6453-5611-4846-ad5b-083dac66b928", "hbainbridge@lfrc.com", true, "Holly", "Bainbridge", true, null, "HBAINBRIDGE@LFRC.COM", "HBAINBRIDGE@LFRC.COM", "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==", null, false, "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7", false, "hbainbridge@lfrc.com" },
                    { "3aca033f-f48d-4a76-ba7c-ac58c629a7ec", 0, 0m, "7edac54f-7633-49b3-8c90-16d35ef60d78", "sjackson@lfrc.com", true, "Shari", "Jackson", true, null, "SJACKSON@LFRC.COM", "SJACKSON@LFRC.COM", "AQAAAAIAAYagAAAAEA0BPAhDLT/LEHuJKiiaJf3BLfFUXqifp5DPoT5RdDZRMRg9mbTSKxqX3sSJkPjqcA==", null, false, "EJGQIJIGPYKWNJSP2LHJZH47HK4NGRPJ", false, "sjackson@lfrc.com" },
                    { "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 0, 100.00m, "d3bf6453-5611-4846-ad5b-083dac66b928", "dhart@lfrc.com", true, "Devin", "Hart", true, null, "DHART@LFRC.COM", "DHART@LFRC.COM", "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==", null, false, "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7", false, "dhart@lfrc.com" },
                    { "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, 250.00m, "b1620237-28ff-4aef-b536-acb35ee49e4f", "cdurbin@lfrc.com", true, "Carrie", "Durbin", true, null, "CDURBIN@LFRC.COM", "CDURBIN@LFRC.COM", "AQAAAAIAAYagAAAAEC8zLHn4ZizET8ultmwR/nf14f4csdC0hr1NWDuwm9nHzamGBnZ1tlBd1LCtkmPaww==", null, false, "5UMDLZ7ACFLFMOA637F2ZYXGTLUFY6G2", false, "cdurbin@lfrc.com" },
                    { "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, 150.00m, "d3bf6453-5611-4846-ad5b-083dac66b928", "tcolson@lfrc.com", true, "Tara", "Colson", true, null, "TCOLSON@LFRC.COM", "TCOLSON@LFRC.COM", "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==", null, false, "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7", false, "tcolson@lfrc.com" },
                    { "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 0, 140.00m, "d3bf6453-5611-4846-ad5b-083dac66b928", "jmarshall@lfrc.com", true, "James", "Marshall", true, null, "JMARSHALL@LFRC.COM", "JMARSHALL@LFRC.COM", "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==", null, false, "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7", false, "jmarshall@lfrc.com" },
                    { "ecb59549-4167-4315-a89f-2bf998b1c289", 0, 0m, "dcb52449-7275-42ad-baea-3213d588c2be", "mshoreheim@lfrc.com", true, "Marty", "Shoreheim", true, null, "MSHOREHEIM@LFRC.COM", "MSHOREHEIM@LFRC.COM", "AQAAAAIAAYagAAAAEO2wfiod2bMvxEqkDwbnFM88xtPo2gOSM0KrJ5nJJ4M38Dnx1Qk2WoXKiLPVpOF/ww==", null, false, "YS2QTXJ5CFFBKWKIVRJVQTDVCS6ZARIU", false, "mshoreheim@lfrc.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "398d1dda-bc39-4208-b358-f888bfbb2ee9" },
                    { "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD", "3aca033f-f48d-4a76-ba7c-ac58c629a7ec" },
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "6cf1351a-f2b6-4504-8d22-25b3dd5437e8" },
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "afcd7a50-a4f1-4a5f-831c-94b945f10371" },
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "c22d84fe-375b-4fcd-ae74-ff1235df78e2" },
                    { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "e666cea7-25b1-4e1e-b6fd-90a536f96ac8" },
                    { "A83849D4-4393-4930-9C1A-319AA1572F59", "ecb59549-4167-4315-a89f-2bf998b1c289" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToId", "BillableHours", "Closed", "Created", "CreatorId", "CustomerId", "Description", "Modified", "ModifierId", "Status", "Title" },
                values: new object[,]
                {
                    { 5, null, 35, null, new DateTime(2018, 10, 23, 6, 8, 18, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 3, 15, 3, 24, 50, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, "Incident 5" },
                    { 6, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 32, null, new DateTime(2018, 12, 13, 5, 53, 12, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 22, 2, 3, 36, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "Incident 6" },
                    { 7, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 7, null, new DateTime(2019, 6, 6, 19, 52, 30, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 26, 12, 3, 25, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "Incident 7" },
                    { 8, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 25, null, new DateTime(2022, 9, 15, 23, 58, 57, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 9, 16, 12, 29, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 8" },
                    { 9, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 13, new DateTime(2022, 12, 8, 14, 0, 19, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 19, 9, 2, 21, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 8, 14, 0, 19, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 9" },
                    { 10, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 25, null, new DateTime(2019, 7, 27, 7, 52, 47, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 3, 29, 4, 43, 37, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 10" },
                    { 11, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 30, null, new DateTime(2019, 9, 6, 4, 0, 55, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 6, 5, 8, 4, 9, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 11" },
                    { 12, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 34, new DateTime(2023, 1, 22, 15, 44, 8, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 3, 17, 22, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 22, 15, 44, 8, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 12" },
                    { 13, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 36, new DateTime(2019, 4, 24, 21, 49, 32, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 26, 0, 48, 48, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 4, 24, 21, 49, 32, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 13" },
                    { 14, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 39, null, new DateTime(2018, 3, 20, 8, 46, 57, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 1, 12, 17, 44, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 4, "Incident 14" },
                    { 15, null, 28, null, new DateTime(2021, 11, 9, 17, 44, 13, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 11, 14, 44, 51, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, "Incident 15" },
                    { 16, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 20, null, new DateTime(2020, 11, 2, 7, 13, 32, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 11, 2, 7, 13, 32, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 4, "Incident 16" },
                    { 17, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 32, null, new DateTime(2019, 5, 19, 14, 37, 16, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 2, 18, 3, 18, 35, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 17" },
                    { 18, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 27, null, new DateTime(2018, 3, 21, 14, 3, 23, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 5, 3, 14, 45, 53, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 4, "Incident 18" },
                    { 19, null, 27, null, new DateTime(2022, 1, 15, 5, 28, 56, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 8, 28, 2, 20, 3, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 19" },
                    { 20, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 6, null, new DateTime(2020, 11, 1, 17, 20, 29, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 5, 19, 26, 31, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 4, "Incident 20" },
                    { 21, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 31, null, new DateTime(2019, 2, 28, 1, 26, 20, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 21, 19, 51, 32, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 21" },
                    { 22, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 8, null, new DateTime(2019, 1, 17, 12, 14, 42, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 1, 17, 12, 14, 42, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "Incident 22" },
                    { 23, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 28, null, new DateTime(2021, 5, 17, 22, 12, 8, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 4, 17, 23, 14, 53, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 4, "Incident 23" },
                    { 24, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 15, null, new DateTime(2021, 7, 16, 5, 27, 57, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 30, 8, 9, 8, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 24" },
                    { 25, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 6, null, new DateTime(2019, 9, 29, 19, 43, 4, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 5, 11, 18, 9, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 4, "Incident 25" },
                    { 26, null, 28, null, new DateTime(2020, 10, 11, 0, 35, 38, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 7, 3, 43, 22, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 26" },
                    { 27, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 32, new DateTime(2023, 1, 23, 20, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 21, 7, 47, 28, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 23, 20, 40, 0, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 27" },
                    { 28, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 40, new DateTime(2022, 11, 26, 13, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 4, 12, 16, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 26, 13, 11, 52, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 3, "Incident 28" },
                    { 29, null, 29, null, new DateTime(2018, 3, 23, 15, 17, 10, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 5, 17, 15, 56, 26, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 0, "Incident 29" },
                    { 30, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 28, new DateTime(2022, 12, 8, 17, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 23, 58, 21, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 8, 17, 10, 57, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 3, "Incident 30" },
                    { 31, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 40, new DateTime(2022, 11, 20, 6, 38, 41, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 13, 8, 29, 15, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 6, 13, 8, 29, 15, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 31" },
                    { 32, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 15, null, new DateTime(2018, 7, 31, 22, 57, 46, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 11, 18, 14, 33, 8, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 4, "Incident 32" },
                    { 33, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 8, null, new DateTime(2021, 8, 5, 15, 50, 37, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 7, 31, 7, 26, 17, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 33" },
                    { 34, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 8, new DateTime(2021, 9, 17, 6, 33, 22, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 24, 17, 29, 16, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 9, 17, 6, 33, 22, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 3, "Incident 34" },
                    { 35, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 22, new DateTime(2021, 10, 4, 9, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 5, 3, 27, 5, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 10, 4, 9, 9, 17, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 35" },
                    { 36, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 39, null, new DateTime(2018, 8, 18, 2, 13, 26, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 3, 25, 6, 32, 16, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 36" },
                    { 37, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 26, null, new DateTime(2018, 2, 27, 12, 39, 36, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 6, 5, 20, 33, 4, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "Incident 37" },
                    { 38, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 28, new DateTime(2022, 3, 2, 9, 1, 55, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 16, 1, 45, 59, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 3, 2, 9, 1, 55, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 38" },
                    { 39, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 22, new DateTime(2022, 7, 6, 2, 9, 28, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 16, 28, 4, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 7, 6, 2, 9, 28, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 39" },
                    { 40, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 38, null, new DateTime(2020, 7, 6, 18, 2, 19, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 7, 6, 18, 2, 19, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "Incident 40" },
                    { 41, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 23, new DateTime(2021, 2, 14, 13, 17, 31, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 3, 9, 26, 24, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 2, 14, 13, 17, 31, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 41" },
                    { 42, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 21, new DateTime(2022, 7, 10, 7, 18, 38, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 9, 19, 9, 11, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 7, 10, 7, 18, 38, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 42" },
                    { 43, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 22, new DateTime(2020, 8, 10, 11, 38, 9, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 24, 13, 10, 13, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 8, 10, 11, 38, 9, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 43" },
                    { 44, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 15, null, new DateTime(2022, 9, 26, 16, 52, 40, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 17, 11, 33, 57, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 44" },
                    { 45, null, 38, null, new DateTime(2019, 7, 11, 16, 7, 55, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 7, 11, 16, 7, 55, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 0, "Incident 45" },
                    { 46, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 22, null, new DateTime(2020, 1, 6, 6, 9, 25, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 2, 2, 0, 10, 0, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 2, "Incident 46" },
                    { 47, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 12, null, new DateTime(2018, 6, 5, 20, 34, 15, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 9, 3, 19, 22, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 4, "Incident 47" },
                    { 48, "398d1dda-bc39-4208-b358-f888bfbb2ee9", 5, null, new DateTime(2019, 5, 14, 21, 51, 43, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 3, 23, 23, 5, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "Incident 48" },
                    { 49, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, null, new DateTime(2021, 9, 7, 23, 20, 18, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 9, 30, 6, 29, 31, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 49" },
                    { 50, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 9, null, new DateTime(2018, 12, 23, 14, 37, 0, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 9, 5, 54, 8, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 2, "Incident 50" },
                    { 51, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 11, null, new DateTime(2019, 8, 12, 7, 15, 17, 0, DateTimeKind.Unspecified), "398d1dda-bc39-4208-b358-f888bfbb2ee9", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 11, 14, 9, 36, 43, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 51" },
                    { 52, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 28, null, new DateTime(2018, 1, 6, 11, 54, 19, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2018, 1, 6, 11, 54, 19, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 4, "Incident 52" },
                    { 53, null, 36, null, new DateTime(2018, 2, 17, 14, 26, 37, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 23, 19, 27, 20, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 53" },
                    { 54, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 36, null, new DateTime(2020, 8, 17, 4, 42, 52, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 8, 17, 4, 42, 52, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 54" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "398d1dda-bc39-4208-b358-f888bfbb2ee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD", "3aca033f-f48d-4a76-ba7c-ac58c629a7ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "6cf1351a-f2b6-4504-8d22-25b3dd5437e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "afcd7a50-a4f1-4a5f-831c-94b945f10371" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "c22d84fe-375b-4fcd-ae74-ff1235df78e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7", "e666cea7-25b1-4e1e-b6fd-90a536f96ac8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A83849D4-4393-4930-9C1A-319AA1572F59", "ecb59549-4167-4315-a89f-2bf998b1c289" });

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "398d1dda-bc39-4208-b358-f888bfbb2ee9");

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
                keyValue: "c22d84fe-375b-4fcd-ae74-ff1235df78e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e666cea7-25b1-4e1e-b6fd-90a536f96ac8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecb59549-4167-4315-a89f-2bf998b1c289");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Closed",
                table: "Tickets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
