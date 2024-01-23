using Microsoft.EntityFrameworkCore;
using TicketPro.Conversions;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Services;

public class TicketService(IDbContextFactory<ApplicationDbContext> contextFactory) : ITicketService
{
    public async Task<TicketDto> CreateTicketAsync(CreateTicketDto request)
    {
        var now = DateTime.Now;
        
        var newTicket = new Ticket
        {
            Id = 0,
            Title = request.Title,
            Description = request.Description,
            CreatorId = request.CreatorId,
            ModifierId = request.ModifierId,
            CustomerId = request.CustomerId,
            Status = request.Status,
            Created = now,
            Modified = now,
            AssignedToId = request.AssignedToId
        };

        var dbContext = await contextFactory.CreateDbContextAsync();

        await dbContext.Tickets.AddAsync(newTicket);
        await dbContext.SaveChangesAsync();

        return newTicket.ToDto();
    }

    public async Task<TicketUpdateDto> UpdateTicketAsync(CreateTicketUpdateDto request)
    {
        var now = DateTime.Now;

        var newUpdate = new TicketUpdate
        {
            Id = 0,
            Note = request.Note,
            CreatorId = request.CreatorId,
            Created = now,
            Modified = now,
            ModifierId = request.CreatorId,
            HoursWorked = request.HoursWorked,
            IsResolution = request.IsResolution,
            TicketId = request.TicketId
        };

        var dbContext = await contextFactory.CreateDbContextAsync();

        var ticketToUpdate = await dbContext.Tickets.FindAsync(request.TicketId);

        if (ticketToUpdate is null)
        {
            throw new Exception($"Ticket with id: {request.TicketId} not found");
        }
        
        if (request.ShouldUpdateStatus)
        {
            ticketToUpdate.Status = request.NewStatus;
        }

        await dbContext.AddAsync(newUpdate);
        await dbContext.SaveChangesAsync();

        return newUpdate.ToDto();
    }

    public async Task<CustomerDto[]> GetCustomersAsync()
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        return await dbContext.Customers
            .AsNoTracking()
            .Select(c => new CustomerDto
            {
                Id = c.Id,
                Name = c.Name,
                StreetAddress = c.StreetAddress,
                City = c.City,
                State = c.State,
                Zip = c.Zip
            })
            .ToArrayAsync();
    }

    public async Task<List<TicketDto>> GetTicketsAsync(int itemsPerPage = 10, int currentPage = 1)
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        return await dbContext.Tickets
            .Include(t => t.Creator)
            .Include(t => t.Modifier)
            .Include(t => t.AssignedTo)
            .Include(t => t.Customer)
            .OrderByDescending(t => t.Created)
            .Skip(itemsPerPage * (currentPage - 1))
            .Take(itemsPerPage)
            .Select(t => t.ToDto())
            .ToListAsync();
    }

    public async Task<int> GetTicketCountAsync()
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        return await dbContext.Tickets.CountAsync();
    }

    public async Task<TicketDto?> GetTicketByIdAsync(int ticketId)
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        var ticket = await dbContext.Tickets.FindAsync(ticketId);

        return ticket?.ToDto();
    }
}