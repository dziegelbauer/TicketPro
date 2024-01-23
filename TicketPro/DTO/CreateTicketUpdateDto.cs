using System.ComponentModel.DataAnnotations;
using TicketPro.Data.Models;

namespace TicketPro.DTO;

public class CreateTicketUpdateDto
{
    public int TicketId { get; set; }
    public string? CreatorId { get; set; }
    [Required]
    public string? Note { get; set; }
    public DateTime Created { get; set; }
    public bool IsResolution { get; set; }
    public bool ShouldUpdateStatus { get; set; }
    public TicketStatus NewStatus { get; set; }
    public int HoursWorked { get; set; }
}