namespace TicketPro.DTO;

public class SearchFilterDto
{
    public TicketStatusFilter TicketStatus { get; set; } = TicketStatusFilter.Any;
    public int CustomerId { get; set; } = -1;
    public string AssignedTo { get; set; } = "any";
    public string CreatedBy { get; set; } = "any";
    public DateTime? CreatedAfter { get; set; }
    public DateTime? CreatedBefore { get; set; }
    public string SearchString { get; set; } = string.Empty;
}