using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketPro.Data.Models;

namespace TicketPro.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<TicketUpdate> TicketUpdates => Set<TicketUpdate>();
    public DbSet<Customer> Customers => Set<Customer>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

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

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "ecb59549-4167-4315-a89f-2bf998b1c289",
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
            });
    }
}