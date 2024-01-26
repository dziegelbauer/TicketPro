using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicketPro.Conversions;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;
using TicketPro.Exceptions;

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
            throw new NullUserException("Attempt to create ticket without a user id");
        }
        
        var creator = await userManager.FindByNameAsync(request.Creator);

        if (creator is null)
        {
            throw new UserNotFoundException("Attempt to create ticket without a valid user id");
        }

        if (request.AssignedToId is null)
        {
            if(request.Status == TicketStatus.Assigned)
            {
                request.Status = TicketStatus.Open;
            }
        }
        else
        {
            var assignee = await userManager.FindByIdAsync(request.AssignedToId);

            if (assignee is null)
            {
                throw new UserNotFoundException("Attempt to assign ticket to an invalid user id");
            }

            if (request.Status == TicketStatus.Open)
            {
                request.Status = TicketStatus.Assigned;
            }
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

    public async Task<List<TicketDto>> GetTicketsAsync(SearchFilterDto searchFilter)
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        var query = dbContext.Tickets
            .Include(t => t.Creator)
            .Include(t => t.Modifier)
            .Include(t => t.AssignedTo)
            .Include(t => t.Customer)
            .AsNoTracking();

        if (searchFilter.TicketStatus != TicketStatusFilter.Any)
        {
            var statusFilter = searchFilter.TicketStatus switch
            {
                TicketStatusFilter.Open => TicketStatus.Open,
                TicketStatusFilter.Assigned => TicketStatus.Assigned,
                TicketStatusFilter.Deferred => TicketStatus.Deferred,
                TicketStatusFilter.Closed => TicketStatus.Closed,
                TicketStatusFilter.Cancelled => TicketStatus.Cancelled,
                _ => throw new Exception("Invalid TicketStatusFilter")
            };

            query = query.Where(t => t.Status == statusFilter);
        }

        if (searchFilter.AssignedTo != "any")
        {
            query = query.Where(t => t.AssignedToId == searchFilter.AssignedTo);
        }

        if (searchFilter.CreatedBy != "any")
        {
            query = query.Where(t => t.CreatorId == searchFilter.CreatedBy);
        }

        if (searchFilter.CustomerId != -1)
        {
            query = query.Where(t => t.CustomerId == searchFilter.CustomerId);
        }

        if (searchFilter.CreatedBefore is not null)
        {
            query = query.Where(t => t.Created < searchFilter.CreatedBefore);
        }

        if (searchFilter.CreatedAfter is not null)
        {
            query = query.Where(t => t.Created > searchFilter.CreatedAfter);
        }

        if (!string.IsNullOrWhiteSpace(searchFilter.SearchString))
        {
            query = query.Where(t => 
                (t.Description != null && t.Description.Contains(searchFilter.SearchString))
                 || (t.Title != null && t.Title.Contains(searchFilter.SearchString)));
        }

        return await query.Select(t => t.ToDto()).ToListAsync();
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
            throw new TicketNotFoundException($"Ticket with id: {ticketId} not found");
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
            throw new TicketNotFoundException($"Ticket with id: {updateTicketRequest.Id} not found");
        }
        
        var modifier = await userManager.FindByNameAsync(updateTicketRequest.Modifier!);

        if (modifier is null)
        {
            throw new UserNotFoundException("Attempt to update ticket without a valid user id");
        }
        
        updateTicketRequest.Modifier = modifier.Id;
        
        if (updateTicketRequest.AssignedToId is null)
        {
            if(updateTicketRequest.Status == TicketStatus.Assigned)
            {
                updateTicketRequest.Status = TicketStatus.Open;
            }
        }
        else
        {
            var assignee = await userManager.FindByIdAsync(updateTicketRequest.AssignedToId);

            if (assignee is null)
            {
                throw new UserNotFoundException("Attempt to assign ticket to an invalid user id");
            }

            if (updateTicketRequest.Status == TicketStatus.Open)
            {
                updateTicketRequest.Status = TicketStatus.Assigned;
            }
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
            throw new TicketNotFoundException($"Ticket with id: {ticketId} not found");
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
                TotalTickets = tickets.Count,
                TotalRevenue = 0
            };

            foreach (var ticket in tickets)
            {
                data.TotalRevenue += ticket.BillableHours * ticket.AssignedTo!.ChargeableRate;
            }
            
            dataList.Add(data);
        }

        return dataList;
    }

    public async Task<List<TicketStatusDataDto>> GetTicketStatusDataAsync()
    {
        var dbContext = await contextFactory.CreateDbContextAsync();

        return await dbContext.Tickets
            .AsNoTracking()
            .Select(t => new TicketStatusDataDto
            {
                Id = t.Id,
                Status = t.Status
            })
            .ToListAsync();
    }
}