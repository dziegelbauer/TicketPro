using System.ComponentModel.DataAnnotations;
using TicketPro.Data.Models;

namespace TicketPro.DTO;

public class CreateTicketDto
{
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    public string? Creator { get; set; }
    public string? AssignedToId { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must select a customer for the ticket.")]
    public int CustomerId { get; set; }
    public TicketStatus Status { get; set; }
}