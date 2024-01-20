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
                Name = "Admin"
            },
            new IdentityRole
            {
                Id = "A83849D4-4393-4930-9C1A-319AA1572F59",
                Name = "Executive"
            },
            new IdentityRole
            {
                Id = "3D8EEDC8-9B0C-4921-9681-4A55D35BD5DD",
                Name = "Manager"
            },
            new IdentityRole
            {
                Id = "F9D9FA29-3F33-4C3C-9CA2-A51B11581DB7",
                Name = "Technician"
            });
    }
}