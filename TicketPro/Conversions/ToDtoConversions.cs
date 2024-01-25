using TicketPro.Data;
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
            CreatorName = t.Creator != null
                ? $"{t.Creator.FirstName} {t.Creator.LastName}"
                : null,
            ModifierId = t.ModifierId,
            ModifierName = t.Modifier != null
                ? $"{t.Modifier.FirstName} {t.Modifier.LastName}"
                : null,
            AssignedToId = t.AssignedToId,
            AssignedToName = t.AssignedTo != null
                ? $"{t.AssignedTo.FirstName} {t.AssignedTo.LastName}"
                : null,
            CustomerId = t.CustomerId,
            CustomerName = t.Customer?.Name,
            Created = t.Created,
            Modified = t.Modified,
            Closed = t.Closed,
            Status = t.Status,
            BillableHours = t.BillableHours
        };
    }

    public static UserDto ToDto(this ApplicationUser u)
    {
        return new UserDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email
        };
    }
}