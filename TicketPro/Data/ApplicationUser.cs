using Microsoft.AspNetCore.Identity;

namespace TicketPro.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public decimal ChargeableRate { get; set; }
}