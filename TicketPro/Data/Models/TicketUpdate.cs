using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketPro.Data.Models;

public class TicketUpdate
{
    public int Id { get; set; }
    [Required]
    public string? Note { get; set; }
    public bool IsResolution { get; set; }
    [ForeignKey(nameof(Creator))]
    public string? CreatorId { get; set; }
    public ApplicationUser? Creator { get; set; }
    [ForeignKey(nameof(Modifier))]
    public string? ModifierId { get; set; }
    public ApplicationUser? Modifier { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public byte[]? Timestamp { get; set; }
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; } = null!;
    public int HoursWorked { get; set; }
}