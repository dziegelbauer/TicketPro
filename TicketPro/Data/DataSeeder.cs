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
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 21,
				Created = DateTime.ParseExact("05/08/2022 20:07:45", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("23/01/2023 17:00:41", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("23/01/2023 17:00:41", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 6,
				Title = "Incident 6",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 29,
				Created = DateTime.ParseExact("06/11/2021 23:30:09", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("08/12/2022 01:23:19", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 7,
				Title = "Incident 7",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 15,
				Created = DateTime.ParseExact("12/09/2022 03:43:46", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("12/09/2022 03:43:46", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("18/01/2023 23:46:01", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 8,
				Title = "Incident 8",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 2,
				BillableHours = 30,
				Created = DateTime.ParseExact("07/04/2019 13:44:10", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("07/04/2019 13:44:10", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 9,
				Title = "Incident 9",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Deferred,
				CustomerId = 1,
				BillableHours = 20,
				Created = DateTime.ParseExact("18/01/2020 07:24:33", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("19/11/2021 09:04:13", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 10,
				Title = "Incident 10",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 29,
				Created = DateTime.ParseExact("16/06/2021 17:54:37", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/09/2022 20:58:32", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("25/09/2022 20:58:32", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 11,
				Title = "Incident 11",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 26,
				Created = DateTime.ParseExact("26/09/2021 14:17:24", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("29/03/2022 21:11:25", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 12,
				Title = "Incident 12",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 7,
				Created = DateTime.ParseExact("21/10/2018 10:47:38", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/09/2021 10:05:38", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 13,
				Title = "Incident 13",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Deferred,
				CustomerId = 1,
				BillableHours = 35,
				Created = DateTime.ParseExact("06/01/2019 03:23:13", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("24/12/2020 17:38:01", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 14,
				Title = "Incident 14",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 39,
				Created = DateTime.ParseExact("23/07/2020 00:27:42", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("23/07/2020 00:27:42", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("03/10/2022 02:13:31", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 15,
				Title = "Incident 15",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 2,
				BillableHours = 12,
				Created = DateTime.ParseExact("17/11/2022 18:51:15", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("23/01/2023 04:54:51", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 16,
				Title = "Incident 16",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 16,
				Created = DateTime.ParseExact("20/11/2022 21:15:20", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("31/12/2022 10:47:57", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 17,
				Title = "Incident 17",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 12,
				Created = DateTime.ParseExact("13/07/2022 19:38:27", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("02/01/2023 08:42:39", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("02/01/2023 08:42:39", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 18,
				Title = "Incident 18",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 12,
				Created = DateTime.ParseExact("28/10/2018 01:22:52", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("28/10/2018 01:22:52", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("06/11/2020 07:55:58", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 19,
				Title = "Incident 19",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 28,
				Created = DateTime.ParseExact("23/04/2021 03:39:21", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("22/01/2023 16:26:27", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 20,
				Title = "Incident 20",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 34,
				Created = DateTime.ParseExact("10/02/2018 23:08:40", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("02/12/2022 17:11:28", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("02/12/2022 17:11:28", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 21,
				Title = "Incident 21",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 15,
				Created = DateTime.ParseExact("27/02/2021 10:00:55", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("29/10/2022 05:01:16", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 22,
				Title = "Incident 22",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 37,
				Created = DateTime.ParseExact("01/08/2021 17:01:26", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("01/08/2021 17:01:26", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 23,
				Title = "Incident 23",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 27,
				Created = DateTime.ParseExact("10/02/2018 11:42:05", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("21/01/2023 20:53:21", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 24,
				Title = "Incident 24",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Deferred,
				CustomerId = 2,
				BillableHours = 32,
				Created = DateTime.ParseExact("16/02/2021 14:08:20", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("27/02/2022 23:49:55", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 25,
				Title = "Incident 25",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 36,
				Created = DateTime.ParseExact("10/02/2019 04:54:13", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/03/2021 18:26:39", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 26,
				Title = "Incident 26",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 39,
				Created = DateTime.ParseExact("16/03/2020 07:41:04", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("20/02/2022 00:19:10", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 27,
				Title = "Incident 27",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 26,
				Created = DateTime.ParseExact("19/02/2019 21:33:35", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("19/02/2019 21:33:35", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 28,
				Title = "Incident 28",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 3,
				Created = DateTime.ParseExact("23/06/2022 01:41:29", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("15/10/2022 03:05:37", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("15/10/2022 03:05:37", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 29,
				Title = "Incident 29",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 32,
				Created = DateTime.ParseExact("01/03/2021 10:36:26", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("24/11/2022 23:20:02", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 30,
				Title = "Incident 30",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 32,
				Created = DateTime.ParseExact("20/09/2022 13:10:57", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("21/12/2022 02:32:54", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 31,
				Title = "Incident 31",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 19,
				Created = DateTime.ParseExact("07/12/2022 11:04:37", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("04/01/2023 21:14:40", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 32,
				Title = "Incident 32",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 9,
				Created = DateTime.ParseExact("23/08/2018 00:43:34", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("22/11/2022 02:37:41", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 33,
				Title = "Incident 33",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 22,
				Created = DateTime.ParseExact("10/12/2021 20:06:24", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("06/11/2022 23:43:07", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 34,
				Title = "Incident 34",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Deferred,
				CustomerId = 2,
				BillableHours = 18,
				Created = DateTime.ParseExact("14/08/2022 13:16:43", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("09/12/2022 16:24:32", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 35,
				Title = "Incident 35",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 30,
				Created = DateTime.ParseExact("28/11/2022 05:13:19", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("11/01/2023 19:46:51", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 36,
				Title = "Incident 36",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 38,
				Created = DateTime.ParseExact("11/05/2020 21:26:31", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("04/07/2022 01:09:03", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 37,
				Title = "Incident 37",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Deferred,
				CustomerId = 2,
				BillableHours = 8,
				Created = DateTime.ParseExact("20/03/2022 07:18:53", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("20/03/2022 07:18:53", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 38,
				Title = "Incident 38",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Deferred,
				CustomerId = 1,
				BillableHours = 10,
				Created = DateTime.ParseExact("28/08/2018 05:13:03", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("28/08/2018 05:13:03", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 39,
				Title = "Incident 39",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 33,
				Created = DateTime.ParseExact("06/01/2021 23:15:40", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("05/01/2023 13:44:56", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("05/01/2023 13:44:56", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 40,
				Title = "Incident 40",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Deferred,
				CustomerId = 2,
				BillableHours = 35,
				Created = DateTime.ParseExact("08/01/2020 04:05:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("05/11/2022 11:48:16", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 41,
				Title = "Incident 41",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				ModifierId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 15,
				Created = DateTime.ParseExact("16/09/2022 17:09:19", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("12/11/2022 12:27:30", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 42,
				Title = "Incident 42",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 30,
				Created = DateTime.ParseExact("22/04/2018 05:58:32", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("23/09/2022 07:36:08", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 43,
				Title = "Incident 43",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				Status = TicketStatus.Deferred,
				CustomerId = 2,
				BillableHours = 26,
				Created = DateTime.ParseExact("16/12/2021 20:19:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/10/2022 13:24:13", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 44,
				Title = "Incident 44",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 11,
				Created = DateTime.ParseExact("09/10/2019 17:16:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("09/10/2019 17:16:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("15/01/2023 07:39:21", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 45,
				Title = "Incident 45",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 22,
				Created = DateTime.ParseExact("26/03/2020 20:13:30", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("12/09/2022 20:38:20", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("12/09/2022 20:38:20", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 46,
				Title = "Incident 46",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Assigned,
				CustomerId = 2,
				BillableHours = 36,
				Created = DateTime.ParseExact("10/12/2019 01:16:58", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("11/03/2021 18:16:27", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 47,
				Title = "Incident 47",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 15,
				Created = DateTime.ParseExact("15/06/2022 03:54:12", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/12/2022 21:46:18", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 48,
				Title = "Incident 48",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Closed,
				CustomerId = 2,
				BillableHours = 29,
				Created = DateTime.ParseExact("30/11/2019 14:01:37", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("18/12/2022 05:26:51", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("18/12/2022 05:26:51", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 49,
				Title = "Incident 49",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 14,
				Created = DateTime.ParseExact("13/01/2019 03:45:05", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("27/05/2021 12:29:53", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("27/05/2021 12:29:53", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 50,
				Title = "Incident 50",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = null,
				Status = TicketStatus.Open,
				CustomerId = 1,
				BillableHours = 34,
				Created = DateTime.ParseExact("15/03/2020 10:14:56", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("24/11/2022 06:16:30", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 51,
				Title = "Incident 51",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				ModifierId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				AssignedToId = "afcd7a50-a4f1-4a5f-831c-94b945f10371",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 19,
				Created = DateTime.ParseExact("05/04/2021 23:13:00", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("13/01/2022 10:58:36", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("13/01/2022 10:58:36", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 52,
				Title = "Incident 52",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				Status = TicketStatus.Closed,
				CustomerId = 1,
				BillableHours = 25,
				Created = DateTime.ParseExact("24/05/2022 03:30:20", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("16/07/2022 23:43:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = DateTime.ParseExact("16/07/2022 23:43:17", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal)
			},
			new Ticket
			{
				Id = 53,
				Title = "Incident 53",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Deferred,
				CustomerId = 1,
				BillableHours = 22,
				Created = DateTime.ParseExact("19/10/2019 08:14:29", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("19/02/2021 16:10:46", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			},
			new Ticket
			{
				Id = 54,
				Title = "Incident 54",
				Description = "The flight represents a breakthrough in \"ionic wind\" technology, which uses a powerful electric field to generate charged nitrogen ions, which are then expelled from the back of the aircraft, generating thrust. Steven Barrett, an aeronautics professor at MIT and the lead author of the study published in the journal Nature, said the inspiration for the project came straight from the science fiction of his childhood. \"I was a big fan of Star Trek, and at that point I thought that the future looked like it should be planes that fly silently, with no moving parts – and maybe have a blue glow.\"",
				CreatorId = "e666cea7-25b1-4e1e-b6fd-90a536f96ac8",
				ModifierId = "6cf1351a-f2b6-4504-8d22-25b3dd5437e8",
				AssignedToId = "c22d84fe-375b-4fcd-ae74-ff1235df78e2",
				Status = TicketStatus.Assigned,
				CustomerId = 1,
				BillableHours = 35,
				Created = DateTime.ParseExact("03/01/2018 16:58:55", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Modified = DateTime.ParseExact("25/03/2019 08:11:35", "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.AdjustToUniversal),
				Closed = null
			});
	}
}