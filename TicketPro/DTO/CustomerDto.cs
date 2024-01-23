namespace TicketPro.DTO;

public class CustomerDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
}