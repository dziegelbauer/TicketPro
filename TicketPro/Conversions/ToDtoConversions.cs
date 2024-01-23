using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Conversions;

public static class ToDtoConversions
{
    public static TicketDto ToDto(this Ticket t)
    {
        return new TicketDto
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            CreatorId = t.CreatorId,
            CreatorName = t.Creator?.UserName,
            ModifierId = t.ModifierId,
            ModifierName = t.Modifier?.UserName,
            AssignedToId = t.AssignedToId,
            AssignedToName = t.AssignedTo?.UserName,
            Created = t.Created,
            Modified = t.Modified,
            Closed = t.Closed,
            Status = t.Status,
            Updates = t.Updates.Select(u => u.ToDto()).ToList()
        };
    }

    public static TicketUpdateDto ToDto(this TicketUpdate tu)
    {
        return new TicketUpdateDto
        {
            Note = tu.Note,
            IsResolution = tu.IsResolution,
            CreatorId = tu.CreatorId,
            CreatorName = tu.Creator?.UserName,
            ModifierId = tu.ModifierId,
            ModifierName = tu.Modifier?.UserName,
            Created = tu.Created,
            Modified = tu.Modified
        };
    }
}