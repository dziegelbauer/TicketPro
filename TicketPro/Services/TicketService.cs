using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicketPro.Conversions;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Services;

public class TicketService(
    IDbContextFactory<ApplicationDbContext> contextFactory, 
    UserManager<ApplicationUser> userManager) 
    : ITicketService
{
    public async Task<TicketDto> CreateTicketAsync(CreateTicketDto request)
    {
        var now = DateTime.UtcNow;

        if (request.Creator is null)
        {
            throw new Exception("Attempt to create ticket without a user id");
        }
        
        var creator = await userManager.FindByNameAsync(request.Creator);

        if (creator is null)
        {
            throw new Exception("Attempt to create ticket without a valid user id");
        }
        
        var newTicket = new Ticket
        {
            Id = 0,
            Title = request.Title,
            Description = request.Description,
            CreatorId = creator.Id,
            ModifierId = creator.Id,
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

        var ticket = await dbContext.Tickets
            .Include(t => t.Creator)
            .Include(t => t.Modifier)
            .Include(t => t.AssignedTo)
            .Include(t => t.Customer)
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Id == ticketId);
        
        if (ticket is null)
        {
            throw new Exception($"Ticket with id: {ticketId} not found");
        }

        return ticket.ToDto();
    }

    public async Task<List<UserDto>> GetTechniciansAsync()
    {
        var technicians = await userManager.GetUsersInRoleAsync("TECHNICIAN");

        return technicians.Select(u => u.ToDto()).ToList();
    }

    public async Task UpdateTicketAsync(UpdateTicketDto updateTicketRequest)
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        var ticket = await dbContext.Tickets.FindAsync(updateTicketRequest.Id);

        if (ticket is null)
        {
            throw new Exception($"Ticket with id: {updateTicketRequest.Id} not found");
        }

        ticket.UpdateFromDto(updateTicketRequest);
        
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteTicketAsync(int ticketId)
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        var ticket = await dbContext.Tickets.FindAsync(ticketId);
        
        if (ticket is null)
        {
            throw new Exception($"Ticket with id: {ticketId} not found");
        }

        dbContext.Tickets.Remove(ticket);
        await dbContext.SaveChangesAsync();
    }

    public async Task<List<TechnicianRevenueDto>> GetTechnicianRevenueDataAsync()
    {
        var dbContext = await contextFactory.CreateDbContextAsync();
        var technicians = await userManager.GetUsersInRoleAsync("TECHNICIAN");

        var dataList = new List<TechnicianRevenueDto>();

        foreach (var technician in technicians)
        {
            var tickets = await dbContext.Tickets
                .AsNoTracking()
                .Where(t => t.Status == TicketStatus.Closed)
                .Where(t => t.AssignedToId == technician.Id)
                .ToListAsync();

            var data = new TechnicianRevenueDto
            {
                TechnicianId = technician.Id,
                TechnicianName = $"{technician.FirstName} {technician.LastName}",
                TotalHours = tickets.Select(t => t.BillableHours).Sum(),
                TotalTickets = tickets.Count
            };

            data.TotalRevenue = data.TotalHours * technician.ChargeableRate;
            
            dataList.Add(data);
        }

        return dataList;
    }

    public async Task<List<CustomerRevenueDto>> GetCustomerRevenueDataAsync()
    {
        var dbContext = await contextFactory.CreateDbContextAsync();
        var customers = await dbContext.Customers
            .AsNoTracking()
            .ToListAsync();

        var dataList = new List<CustomerRevenueDto>();

        foreach (var customer in customers)
        {
            var tickets = await dbContext.Tickets
                .AsNoTracking()
                .Include(t => t.AssignedTo)
                .Where(t => t.Status == TicketStatus.Closed)
                .Where(t => t.CustomerId == customer.Id)
                .Where(t => t.AssignedToId != null)
                .ToListAsync();

            var data = new CustomerRevenueDto
            {
                CustomerId = customer.Id,
                CustomerName = customer.Name!,
                TotalHours = tickets.Select(t => t.BillableHours).Sum(),
                TotalTickets = tickets.Count
            };

            data.TotalRevenue = 0;

            foreach (var ticket in tickets)
            {
                data.TotalRevenue += ticket.BillableHours * ticket.AssignedTo!.ChargeableRate;
            }
            
            dataList.Add(data);
        }

        return dataList;
    }
}