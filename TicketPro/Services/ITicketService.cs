using TicketPro.Data.Models;
using TicketPro.DTO;

namespace TicketPro.Services;

public interface ITicketService
{
    Task<TicketDto> CreateTicketAsync(CreateTicketDto request);
    Task<CustomerDto[]> GetCustomersAsync();
    Task<List<TicketDto>> GetTicketsAsync(int itemsPerPage = 0, int currentPage = 0);
    Task<int> GetTicketCountAsync();
    Task<TicketDto?> GetTicketByIdAsync(int ticketId);
}