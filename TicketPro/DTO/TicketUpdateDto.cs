namespace TicketPro.DTO;

public class TicketUpdateDto
{
    public string? Note { get; set; }
    public bool IsResolution { get; set; }
    public string? CreatorId { get; set; }
    public string? CreatorName { get; set; }
    public string? ModifierId { get; set; }
    public string? ModifierName { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
}