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
                    { 5, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 21, new DateTime(2023, 1, 23, 17, 0, 41, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 20, 7, 45, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 23, 17, 0, 41, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 5" },
                    { 6, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 29, null, new DateTime(2021, 11, 6, 23, 30, 9, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 8, 1, 23, 19, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 6" },
                    { 7, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 15, new DateTime(2023, 1, 18, 23, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 3, 43, 46, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 9, 12, 3, 43, 46, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 7" },
                    { 8, null, 30, null, new DateTime(2019, 4, 7, 13, 44, 10, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 4, 7, 13, 44, 10, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, "Incident 8" },
                    { 9, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 20, null, new DateTime(2020, 1, 18, 7, 24, 33, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 11, 19, 9, 4, 13, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "Incident 9" },
                    { 10, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 29, new DateTime(2022, 9, 25, 20, 58, 32, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 17, 54, 37, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 9, 25, 20, 58, 32, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 10" },
                    { 11, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 26, null, new DateTime(2021, 9, 26, 14, 17, 24, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 3, 29, 21, 11, 25, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 11" },
                    { 12, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 7, null, new DateTime(2018, 10, 21, 10, 47, 38, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 9, 25, 10, 5, 38, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 12" },
                    { 13, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 35, null, new DateTime(2019, 1, 6, 3, 23, 13, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 12, 24, 17, 38, 1, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 13" },
                    { 14, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 39, new DateTime(2022, 10, 3, 2, 13, 31, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 23, 0, 27, 42, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2020, 7, 23, 0, 27, 42, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 14" },
                    { 15, null, 12, null, new DateTime(2022, 11, 17, 18, 51, 15, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 23, 4, 54, 51, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 15" },
                    { 16, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 16, null, new DateTime(2022, 11, 20, 21, 15, 20, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 31, 10, 47, 57, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 16" },
                    { 17, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 12, new DateTime(2023, 1, 2, 8, 42, 39, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 19, 38, 27, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 2, 8, 42, 39, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 17" },
                    { 18, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 12, new DateTime(2020, 11, 6, 7, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 28, 1, 22, 52, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2018, 10, 28, 1, 22, 52, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 18" },
                    { 19, null, 28, null, new DateTime(2021, 4, 23, 3, 39, 21, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 22, 16, 26, 27, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 19" },
                    { 20, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 34, new DateTime(2022, 12, 2, 17, 11, 28, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 23, 8, 40, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 2, 17, 11, 28, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 20" },
                    { 21, null, 15, null, new DateTime(2021, 2, 27, 10, 0, 55, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 29, 5, 1, 16, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 0, "Incident 21" },
                    { 22, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 37, null, new DateTime(2021, 8, 1, 17, 1, 26, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 8, 1, 17, 1, 26, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 22" },
                    { 23, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 27, null, new DateTime(2018, 2, 10, 11, 42, 5, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 21, 20, 53, 21, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 23" },
                    { 24, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 32, null, new DateTime(2021, 2, 16, 14, 8, 20, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 2, 27, 23, 49, 55, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 24" },
                    { 25, null, 36, null, new DateTime(2019, 2, 10, 4, 54, 13, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 3, 25, 18, 26, 39, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, "Incident 25" },
                    { 26, null, 39, null, new DateTime(2020, 3, 16, 7, 41, 4, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 2, 20, 0, 19, 10, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 0, "Incident 26" },
                    { 27, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 26, null, new DateTime(2019, 2, 19, 21, 33, 35, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 2, 19, 21, 33, 35, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 27" },
                    { 28, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 3, new DateTime(2022, 10, 15, 3, 5, 37, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 1, 41, 29, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 15, 3, 5, 37, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 28" },
                    { 29, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 32, null, new DateTime(2021, 3, 1, 10, 36, 26, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 24, 23, 20, 2, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 29" },
                    { 30, null, 32, null, new DateTime(2022, 9, 20, 13, 10, 57, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 21, 2, 32, 54, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 0, "Incident 30" },
                    { 31, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 19, null, new DateTime(2022, 12, 7, 11, 4, 37, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 4, 21, 14, 40, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 31" },
                    { 32, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 9, null, new DateTime(2018, 8, 23, 0, 43, 34, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 22, 2, 37, 41, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 32" },
                    { 33, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 22, null, new DateTime(2021, 12, 10, 20, 6, 24, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 6, 23, 43, 7, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 33" },
                    { 34, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 18, null, new DateTime(2022, 8, 14, 13, 16, 43, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 9, 16, 24, 32, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 34" },
                    { 35, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 30, null, new DateTime(2022, 11, 28, 5, 13, 19, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 11, 19, 46, 51, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "Incident 35" },
                    { 36, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 38, null, new DateTime(2020, 5, 11, 21, 26, 31, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 7, 4, 1, 9, 3, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 36" },
                    { 37, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 8, null, new DateTime(2022, 3, 20, 7, 18, 53, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 3, 20, 7, 18, 53, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "Incident 37" },
                    { 38, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 10, null, new DateTime(2018, 8, 28, 5, 13, 3, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2018, 8, 28, 5, 13, 3, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "Incident 38" },
                    { 39, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 33, new DateTime(2023, 1, 5, 13, 44, 56, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 23, 15, 40, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2023, 1, 5, 13, 44, 56, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 39" },
                    { 40, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 35, null, new DateTime(2020, 1, 8, 4, 5, 17, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 5, 11, 48, 16, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "Incident 40" },
                    { 41, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 15, null, new DateTime(2022, 9, 16, 17, 9, 19, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 12, 12, 27, 30, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "Incident 41" },
                    { 42, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 30, null, new DateTime(2018, 4, 22, 5, 58, 32, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 9, 23, 7, 36, 8, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 42" },
                    { 43, "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 26, null, new DateTime(2021, 12, 16, 20, 19, 17, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 10, 25, 13, 24, 13, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "Incident 43" },
                    { 44, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 11, new DateTime(2023, 1, 15, 7, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 9, 17, 16, 17, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 10, 9, 17, 16, 17, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 44" },
                    { 45, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 22, new DateTime(2022, 9, 12, 20, 38, 20, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 26, 20, 13, 30, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 9, 12, 20, 38, 20, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 45" },
                    { 46, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 36, null, new DateTime(2019, 12, 10, 1, 16, 58, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 3, 11, 18, 16, 27, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "Incident 46" },
                    { 47, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 15, null, new DateTime(2022, 6, 15, 3, 54, 12, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 25, 21, 46, 18, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 47" },
                    { 48, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 29, new DateTime(2022, 12, 18, 5, 26, 51, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 30, 14, 1, 37, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 2, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 12, 18, 5, 26, 51, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 48" },
                    { 49, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 14, new DateTime(2021, 5, 27, 12, 29, 53, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 13, 3, 45, 5, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 5, 27, 12, 29, 53, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 3, "Incident 49" },
                    { 50, null, 34, null, new DateTime(2020, 3, 15, 10, 14, 56, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 11, 24, 6, 16, 30, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 0, "Incident 50" },
                    { 51, "afcd7a50-a4f1-4a5f-831c-94b945f10371", 19, new DateTime(2022, 1, 13, 10, 58, 36, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 23, 13, 0, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 1, 13, 10, 58, 36, 0, DateTimeKind.Unspecified), "afcd7a50-a4f1-4a5f-831c-94b945f10371", 3, "Incident 51" },
                    { 52, "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 25, new DateTime(2022, 7, 16, 23, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 3, 30, 20, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2022, 7, 16, 23, 43, 17, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 3, "Incident 52" },
                    { 53, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 22, null, new DateTime(2019, 10, 19, 8, 14, 29, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2021, 2, 19, 16, 10, 46, 0, DateTimeKind.Unspecified), "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 2, "Incident 53" },
                    { 54, "c22d84fe-375b-4fcd-ae74-ff1235df78e2", 35, null, new DateTime(2018, 1, 3, 16, 58, 55, 0, DateTimeKind.Unspecified), "e666cea7-25b1-4e1e-b6fd-90a536f96ac8", 1, "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"", new DateTime(2019, 3, 25, 8, 11, 35, 0, DateTimeKind.Unspecified), "6cf1351a-f2b6-4504-8d22-25b3dd5437e8", 1, "Incident 54" }
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
        }
    }
}
