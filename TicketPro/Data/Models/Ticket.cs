using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketPro.Data.Models;

public class Ticket
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [ForeignKey(nameof(Creator))]
    public string? CreatorId { get; set; }
    public ApplicationUser? Creator { get; set; }
    [ForeignKey(nameof(Modifier))]
    public string? ModifierId { get; set; }
    public ApplicationUser? Modifier { get; set; }
    [ForeignKey(nameof(AssignedTo))]
    public string? AssignedToId { get; set; }
    public ApplicationUser? AssignedTo { get; set; }
    [Timestamp]
    public byte[]? Timestamp { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime? Closed { get; set; }
    public TicketStatus Status { get; set; }
}