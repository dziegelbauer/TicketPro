namespace TicketPro.DTO;

public class CustomerRevenueDto
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public decimal TotalRevenue { get; set; }
    public int TotalHours { get; set; }
    public int TotalTickets { get; set; }
}