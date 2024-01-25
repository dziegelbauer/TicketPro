namespace TicketPro.DTO;

public class TechnicianRevenueDto
{
    public string TechnicianId { get; set; } = string.Empty;
    public string TechnicianName { get; set; } = string.Empty;
    public decimal TotalRevenue { get; set; }
    public int TotalHours { get; set; }
    public int TotalTickets { get; set; }
}