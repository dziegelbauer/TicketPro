using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicketPro.Data.Models;

namespace TicketPro.Data;

public static class DataSeeder
{
    public static void SeedRoles(this ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "104B3E6E-74E7-4CD5-B3BD-2D5567AE4101",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "A83849D4-4393-4930-9C1A-319AA1572F59",
                Name = "Executive",
                NormalizedName = "EXECUTIVE"
            },
            new IdentityRole
            {
                Id = "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD",
                Name = "Manager",
                NormalizedName = "MANAGER"
            },
            new IdentityRole
            {
                Id = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7",
                Name = "Technician",
                NormalizedName = "TECHNICIAN"
            });
    }

    public static void SeedRoleAssignments(this ModelBuilder builder)
    {
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                UserId = "ecb59549-4167-4315-a89f-2bf998b1c289",
                RoleId = "A83849D4-4393-4930-9C1A-319AA1572F59"
            },
            new IdentityUserRole<string>
            {
                UserId = "3aca033f-f48d-4a76-ba7c-ac58c629a7ec",
                RoleId = "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD"
            },
            new IdentityUserRole<string>
            {
                UserId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                RoleId = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7"
            },
            new IdentityUserRole<string>
            {
                UserId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                RoleId = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7"
            },
            new IdentityUserRole<string>
            {
                UserId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                RoleId = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7"
            },
            new IdentityUserRole<string>
            {
                UserId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                RoleId = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7"
            },
            new IdentityUserRole<string>
            {
                UserId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                RoleId = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7"
            }
        );
    }

    public static void SeedCustomers(this ModelBuilder builder)
    {
        builder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1,
                Name = "Rogers Steel",
                StreetAddress = "123 Wasilla Way",
                City = "Sheboygan",
                State = "MI",
                Zip = "12345"
            },
            new Customer
            {
                Id = 2,
                Name = "Brown Motors",
                StreetAddress = "1042 Grand Avenue",
                City = "Toledo",
                State = "OH",
                Zip = "23456"
            },
            new Customer
            {
                Id = 3,
                Name = "Appliance Masters",
                StreetAddress = "23 Highland Ridge Road",
                City = "Big Spur",
                State = "IN",
                Zip = "34567"
            });
    }

    public static void SeedUsers(this ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "ecb59549-4167-4315-a89f-2bf998b1c289",
                FirstName = "Marty",
                LastName = "Shoreheim",
                UserName = "mshoreheim@lfrc.com",
                NormalizedUserName = "MSHOREHEIM@LFRC.COM",
                Email = "mshoreheim@lfrc.com",
                NormalizedEmail = "MSHOREHEIM@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEO2wfiod2bMvxEqkDwbnFM88xtPo2gOSM0KrJ5nJJ4M38Dnx1Qk2WoXKiLPVpOF/ww==",
                SecurityStamp = "YS2QTXJ5CFFBKWKIVRJVQTDVCS6ZARIU",
                ConcurrencyStamp = "dcb52449-7275-42ad-baea-3213d588c2be",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 0
            },
            new ApplicationUser
            {
                Id = "3aca033f-f48d-4a76-ba7c-ac58c629a7ec",
                UserName = "sjackson@lfrc.com",
                FirstName = "Shari",
                LastName = "Jackson",
                NormalizedUserName = "SJACKSON@LFRC.COM",
                Email = "sjackson@lfrc.com",
                NormalizedEmail = "SJACKSON@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEA0BPAhDLT/LEHuJKiiaJf3BLfFUXqifp5DPoT5RdDZRMRg9mbTSKxqX3sSJkPjqcA==",
                SecurityStamp = "EJGQIJIGPYKWNJSP2LHJZH47HK4NGRPJ",
                ConcurrencyStamp = "7edac54f-7633-49b3-8c90-16d35ef60d78",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 0
            },
            new ApplicationUser
            {
                Id = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                FirstName = "Carrie",
                LastName = "Durbin",
                UserName = "cdurbin@lfrc.com",
                NormalizedUserName = "CDURBIN@LFRC.COM",
                Email = "cdurbin@lfrc.com",
                NormalizedEmail = "CDURBIN@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEC8zLHn4ZizET8ultmwR/nf14f4csdC0hr1NWDuwm9nHzamGBnZ1tlBd1LCtkmPaww==",
                SecurityStamp = "5UMDLZ7ACFLFMOA637F2ZYXGTLUFY6G2",
                ConcurrencyStamp = "b1620237-28ff-4aef-b536-acb35ee49e4f",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 250.00M
            },
            new ApplicationUser
            {
                Id = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                FirstName = "Devin",
                LastName = "Hart",
                UserName = "dhart@lfrc.com",
                NormalizedUserName = "DHART@LFRC.COM",
                Email = "dhart@lfrc.com",
                NormalizedEmail = "DHART@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==",
                SecurityStamp = "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7",
                ConcurrencyStamp = "d3bf6453-5611-4846-ad5b-083dac66b928",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 100.00M
            },
            new ApplicationUser
            {
                Id = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                FirstName = "Tara",
                LastName = "Colson",
                UserName = "tcolson@lfrc.com",
                NormalizedUserName = "TCOLSON@LFRC.COM",
                Email = "tcolson@lfrc.com",
                NormalizedEmail = "TCOLSON@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==",
                SecurityStamp = "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7",
                ConcurrencyStamp = "d3bf6453-5611-4846-ad5b-083dac66b928",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 150.00M
            },
            new ApplicationUser
            {
                Id = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                FirstName = "James",
                LastName = "Marshall",
                UserName = "jmarshall@lfrc.com",
                NormalizedUserName = "JMARSHALL@LFRC.COM",
                Email = "jmarshall@lfrc.com",
                NormalizedEmail = "JMARSHALL@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==",
                SecurityStamp = "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7",
                ConcurrencyStamp = "d3bf6453-5611-4846-ad5b-083dac66b928",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 140.00M
            },
            new ApplicationUser
            {
                Id = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                FirstName = "Holly",
                LastName = "Bainbridge",
                UserName = "hbainbridge@lfrc.com",
                NormalizedUserName = "HBAINBRIDGE@LFRC.COM",
                Email = "hbainbridge@lfrc.com",
                NormalizedEmail = "HBAINBRIDGE@LFRC.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAECP8GDTUiYpawW2QH0jQrTb+AusonHhbxf6saK3/oCzmieXQpSy58vCmQe4sOLAgBQ==",
                SecurityStamp = "DXQ32QG3BZXE7V2QZC4HNL5G7FJB4EW7",
                ConcurrencyStamp = "d3bf6453-5611-4846-ad5b-083dac66b928",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                ChargeableRate = 180.00M
            });
    }

    public static void SeedTickets(this ModelBuilder builder)
    {
        builder.Entity<Ticket>().HasData(
            new Ticket
            {
                Id = 5,
                Title = "Incident 5",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 1,
                BillableHours = 35,
                Created = DateTime.ParseExact("23/10/2018 06:08:18", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("15/03/2021 03:24:50", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 6,
                Title = "Incident 6",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Deferred,
                CustomerId = 2,
                BillableHours = 32,
                Created = DateTime.ParseExact("13/12/2018 05:53:12", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("22/10/2022 02:03:36", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 7,
                Title = "Incident 7",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 7,
                Created = DateTime.ParseExact("06/06/2019 19:52:30", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("26/10/2022 12:03:25", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 8,
                Title = "Incident 8",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Deferred,
                CustomerId = 3,
                BillableHours = 25,
                Created = DateTime.ParseExact("15/09/2022 23:58:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("09/01/2023 16:12:29", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 9,
                Title = "Incident 9",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Closed,
                CustomerId = 3,
                BillableHours = 13,
                Created = DateTime.ParseExact("19/09/2019 09:02:21", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("08/12/2022 14:00:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("08/12/2022 14:00:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 10,
                Title = "Incident 10",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 25,
                Created = DateTime.ParseExact("27/07/2019 07:52:47", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("29/03/2021 04:43:37", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 11,
                Title = "Incident 11",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 30,
                Created = DateTime.ParseExact("06/09/2019 04:00:55", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("05/06/2022 08:04:09", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 12,
                Title = "Incident 12",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Closed,
                CustomerId = 1,
                BillableHours = 34,
                Created = DateTime.ParseExact("06/01/2023 03:17:22", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("22/01/2023 15:44:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("22/01/2023 15:44:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 13,
                Title = "Incident 13",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Closed,
                CustomerId = 1,
                BillableHours = 36,
                Created = DateTime.ParseExact("26/07/2018 00:48:48", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("24/04/2019 21:49:32", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("24/04/2019 21:49:32", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 14,
                Title = "Incident 14",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Cancelled,
                CustomerId = 1,
                BillableHours = 39,
                Created = DateTime.ParseExact("20/03/2018 08:46:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("01/12/2022 12:17:44", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 15,
                Title = "Incident 15",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 3,
                BillableHours = 28,
                Created = DateTime.ParseExact("09/11/2021 17:44:13", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("11/01/2023 14:44:51", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 16,
                Title = "Incident 16",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Cancelled,
                CustomerId = 2,
                BillableHours = 20,
                Created = DateTime.ParseExact("02/11/2020 07:13:32", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("02/11/2020 07:13:32", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 17,
                Title = "Incident 17",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 32,
                Created = DateTime.ParseExact("19/05/2019 14:37:16", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("18/02/2020 03:18:35", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 18,
                Title = "Incident 18",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Cancelled,
                CustomerId = 3,
                BillableHours = 27,
                Created = DateTime.ParseExact("21/03/2018 14:03:23", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("03/05/2021 14:45:53", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 19,
                Title = "Incident 19",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 3,
                BillableHours = 27,
                Created = DateTime.ParseExact("15/01/2022 05:28:56", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("28/08/2022 02:20:03", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 20,
                Title = "Incident 20",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Cancelled,
                CustomerId = 2,
                BillableHours = 6,
                Created = DateTime.ParseExact("01/11/2020 17:20:29", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("05/01/2023 19:26:31", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 21,
                Title = "Incident 21",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 31,
                Created = DateTime.ParseExact("28/02/2019 01:26:20", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("21/12/2022 19:51:32", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 22,
                Title = "Incident 22",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 8,
                Created = DateTime.ParseExact("17/01/2019 12:14:42", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/01/2019 12:14:42", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 23,
                Title = "Incident 23",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Cancelled,
                CustomerId = 2,
                BillableHours = 28,
                Created = DateTime.ParseExact("17/05/2021 22:12:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/04/2022 23:14:53", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 24,
                Title = "Incident 24",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Assigned,
                CustomerId = 1,
                BillableHours = 15,
                Created = DateTime.ParseExact("16/07/2021 05:27:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("30/11/2022 08:09:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 25,
                Title = "Incident 25",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Cancelled,
                CustomerId = 2,
                BillableHours = 6,
                Created = DateTime.ParseExact("29/09/2019 19:43:04", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("05/11/2022 11:18:09", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 26,
                Title = "Incident 26",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 2,
                BillableHours = 28,
                Created = DateTime.ParseExact("11/10/2020 00:35:38", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("07/01/2023 03:43:22", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 27,
                Title = "Incident 27",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Closed,
                CustomerId = 3,
                BillableHours = 32,
                Created = DateTime.ParseExact("21/05/2019 07:47:28", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("23/01/2023 20:40:00", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("23/01/2023 20:40:00", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 28,
                Title = "Incident 28",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Closed,
                CustomerId = 2,
                BillableHours = 40,
                Created = DateTime.ParseExact("14/08/2022 04:12:16", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("26/11/2022 13:11:52", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("26/11/2022 13:11:52", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 29,
                Title = "Incident 29",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 2,
                BillableHours = 29,
                Created = DateTime.ParseExact("23/03/2018 15:17:10", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/05/2022 15:56:26", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 30,
                Title = "Incident 30",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Closed,
                CustomerId = 2,
                BillableHours = 28,
                Created = DateTime.ParseExact("21/08/2022 23:58:21", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("08/12/2022 17:10:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("08/12/2022 17:10:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 31,
                Title = "Incident 31",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Closed,
                CustomerId = 1,
                BillableHours = 40,
                Created = DateTime.ParseExact("13/06/2019 08:29:15", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("13/06/2019 08:29:15", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("20/11/2022 06:38:41", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 32,
                Title = "Incident 32",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Cancelled,
                CustomerId = 1,
                BillableHours = 15,
                Created = DateTime.ParseExact("31/07/2018 22:57:46", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("18/11/2021 14:33:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 33,
                Title = "Incident 33",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 8,
                Created = DateTime.ParseExact("05/08/2021 15:50:37", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("31/07/2022 07:26:17", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 34,
                Title = "Incident 34",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Closed,
                CustomerId = 2,
                BillableHours = 8,
                Created = DateTime.ParseExact("24/10/2020 17:29:16", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/09/2021 06:33:22", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("17/09/2021 06:33:22", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 35,
                Title = "Incident 35",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Closed,
                CustomerId = 1,
                BillableHours = 22,
                Created = DateTime.ParseExact("05/05/2021 03:27:05", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("04/10/2021 09:09:17", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("04/10/2021 09:09:17", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 36,
                Title = "Incident 36",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 39,
                Created = DateTime.ParseExact("18/08/2018 02:13:26", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("25/03/2022 06:32:16", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 37,
                Title = "Incident 37",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 26,
                Created = DateTime.ParseExact("27/02/2018 12:39:36", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("05/06/2022 20:33:04", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 38,
                Title = "Incident 38",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Closed,
                CustomerId = 3,
                BillableHours = 28,
                Created = DateTime.ParseExact("16/12/2020 01:45:59", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("02/03/2022 09:01:55", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("02/03/2022 09:01:55", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 39,
                Title = "Incident 39",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Closed,
                CustomerId = 2,
                BillableHours = 22,
                Created = DateTime.ParseExact("01/01/2020 16:28:04", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("06/07/2022 02:09:28", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("06/07/2022 02:09:28", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 40,
                Title = "Incident 40",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 38,
                Created = DateTime.ParseExact("06/07/2020 18:02:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("06/07/2020 18:02:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 41,
                Title = "Incident 41",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Closed,
                CustomerId = 1,
                BillableHours = 23,
                Created = DateTime.ParseExact("03/12/2020 09:26:24", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("14/02/2021 13:17:31", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("14/02/2021 13:17:31", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 42,
                Title = "Incident 42",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                Status = TicketStatus.Closed,
                CustomerId = 2,
                BillableHours = 21,
                Created = DateTime.ParseExact("09/10/2020 19:09:11", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("10/07/2022 07:18:38", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("10/07/2022 07:18:38", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 43,
                Title = "Incident 43",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Closed,
                CustomerId = 3,
                BillableHours = 22,
                Created = DateTime.ParseExact("24/02/2018 13:10:13", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("10/08/2020 11:38:09", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = DateTime.ParseExact("10/08/2020 11:38:09", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal)
            },
            new Ticket
            {
                Id = 44,
                Title = "Incident 44",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Assigned,
                CustomerId = 3,
                BillableHours = 15,
                Created = DateTime.ParseExact("26/09/2022 16:52:40", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/01/2023 11:33:57", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 45,
                Title = "Incident 45",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 2,
                BillableHours = 38,
                Created = DateTime.ParseExact("11/07/2019 16:07:55", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("11/07/2019 16:07:55", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 46,
                Title = "Incident 46",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Deferred,
                CustomerId = 2,
                BillableHours = 22,
                Created = DateTime.ParseExact("06/01/2020 06:09:25", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("02/02/2022 00:10:00", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 47,
                Title = "Incident 47",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Cancelled,
                CustomerId = 2,
                BillableHours = 12,
                Created = DateTime.ParseExact("05/06/2018 20:34:15", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("09/10/2022 03:19:22", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 48,
                Title = "Incident 48",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                Status = TicketStatus.Deferred,
                CustomerId = 1,
                BillableHours = 5,
                Created = DateTime.ParseExact("14/05/2019 21:51:43", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("03/12/2022 23:23:05", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 49,
                Title = "Incident 49",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 3,
                Created = DateTime.ParseExact("07/09/2021 23:20:18", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("30/09/2021 06:29:31", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 50,
                Title = "Incident 50",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                Status = TicketStatus.Deferred,
                CustomerId = 1,
                BillableHours = 9,
                Created = DateTime.ParseExact("23/12/2018 14:37:00", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("09/11/2022 05:54:08", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 51,
                Title = "Incident 51",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "398d1dda-bc39-4208-b358-f888bfbb2ee9",
                ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Assigned,
                CustomerId = 2,
                BillableHours = 11,
                Created = DateTime.ParseExact("12/08/2019 07:15:17", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("14/11/2021 09:36:43", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 52,
                Title = "Incident 52",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Cancelled,
                CustomerId = 3,
                BillableHours = 28,
                Created = DateTime.ParseExact("06/01/2018 11:54:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("06/01/2018 11:54:19", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 53,
                Title = "Incident 53",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
                AssignedToId = null,
                Status = TicketStatus.Open,
                CustomerId = 2,
                BillableHours = 36,
                Created = DateTime.ParseExact("17/02/2018 14:26:37", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("23/10/2022 19:27:20", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            },
            new Ticket
            {
                Id = 54,
                Title = "Incident 54",
                Description =
                    "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
                CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
                AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
                Status = TicketStatus.Deferred,
                CustomerId = 2,
                BillableHours = 36,
                Created = DateTime.ParseExact("17/08/2020 04:42:52", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Modified = DateTime.ParseExact("17/08/2020 04:42:52", "dd/MM/yyyy HH:mm:ss", null,
                    DateTimeStyles.AdjustToUniversal),
                Closed = null
            });
    }
}