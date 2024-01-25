using TicketPro.Data.Models;

namespace TicketPro.DTO;

public class TicketDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? CreatorId { get; set; }
    public string? CreatorName { get; set; }
    public string? ModifierId { get; set; }
    public string? ModifierName { get; set; }
    public string? AssignedToId { get; set; }
    public string? AssignedToName { get; set; }
    public int CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime? Closed { get; set; }
    public TicketStatus Status { get; set; }
    public int BillableHours { get; set; }
}