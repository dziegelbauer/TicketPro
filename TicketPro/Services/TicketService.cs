using Microsoft.EntityFrameworkCore;
using TicketPro.Conversions;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Services;

public class TicketService : ITicketService
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    public TicketService(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    
    public Task<TicketDto> CreateTicketAsync(CreateTicketDto request)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomerDto[]> GetCustomersAsync()
    {
        var dbContext = await _contextFactory.CreateDbContextAsync();

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
        var dbContext = await _contextFactory.CreateDbContextAsync();

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
        var dbContext = await _contextFactory.CreateDbContextAsync();

        return await dbContext.Tickets.CountAsync();
    }

    public async Task<TicketDto?> GetTicketByIdAsync(int ticketId)
    {
        var dbContext = await _contextFactory.CreateDbContextAsync();

        var ticket = await dbContext.Tickets.FindAsync(ticketId);

        return ticket?.ToDto();
    }
}