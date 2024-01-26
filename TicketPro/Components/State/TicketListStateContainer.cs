using TicketPro.DTO;

namespace TicketPro.Components.State;

public class TicketListStateContainer
{
    public int TicketListPage { get; set; }
    public SearchFilterDto SearchFilters { get; set; } = new();
}