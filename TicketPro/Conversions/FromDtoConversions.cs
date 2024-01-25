using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Conversions;

public static class FromDtoConversions
{
    public static void UpdateFromDto(this Ticket ticket, UpdateTicketDto updateTicketRequest)
    {
        ticket.Title = updateTicketRequest.Title;
        ticket.Description = updateTicketRequest.Description;
        ticket.AssignedToId = updateTicketRequest.AssignedToId;
        ticket.ModifierId = updateTicketRequest.Modifier;
        ticket.Status = updateTicketRequest.Status;
        ticket.BillableHours = updateTicketRequest.BillableHours;
        ticket.CustomerId = updateTicketRequest.CustomerId;
        ticket.Modified = DateTime.UtcNow;
    }
}