using Microsoft.EntityFrameworkCore;
using NSubstitute;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;
using TicketPro.Services;

namespace TicketProTest;

[TestFixture]
public class TicketServiceTests
{
    private DbSet<Ticket> _mockDbSet;
    private List<Ticket> _ticketList;
    private IQueryable<Ticket> _data;
    private ApplicationDbContext _mockContext;
    private IDbContextFactory<ApplicationDbContext> _mockContextFactory;
    [SetUp]
    public void Setup()
    {
        _mockDbSet = Substitute.For<DbSet<Ticket>, IQueryable<Ticket>>();
        _ticketList = new List<Ticket>();
        _data = _ticketList.AsQueryable();
        ((IQueryable<Ticket>)_mockDbSet).Provider.Returns(_data.Provider);
        ((IQueryable<Ticket>)_mockDbSet).Expression.Returns(_data.Expression);
        ((IQueryable<Ticket>)_mockDbSet).ElementType.Returns(_data.ElementType);
        ((IQueryable<Ticket>)_mockDbSet).GetEnumerator().Returns(_data.GetEnumerator());
        _mockContext = Substitute.For<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());
        _mockContext.Set<Ticket>().Returns(_mockDbSet);
        _mockContext.Tickets.Returns(_mockDbSet);
        _mockDbSet.Add(Arg.Do<Ticket>(ticket =>
        {
            _ticketList.Add(ticket);
            _data = _ticketList.AsQueryable();
        }));
        _mockContextFactory = Substitute.For<IDbContextFactory<ApplicationDbContext>>();
        _mockContextFactory.CreateDbContextAsync().Returns(Task.FromResult(_mockContext));
    }

    [Test]
    public async Task TicketServiceCanAddTicket()
    {
        var ticketService = new TicketService(_mockContextFactory);

        var creationRequest = new CreateTicketDto
        {
            CustomerId = 1,
            CreatorId = null,
            ModifierId = null,
            AssignedToId = null,
            Description = "This is a test",
            Modified = DateTime.Now,
            Created = DateTime.Now,
            Status = TicketStatus.Open,
            Title = "Test Ticket 1"
        };

        var result = await ticketService.CreateTicketAsync(creationRequest);
        
        Assert.That(result.Id, Is.EqualTo(0));
        Assert.That(result.Title, Is.EqualTo("Test Ticket 1"));
        Assert.That(_ticketList.Count, Is.GreaterThan(0));
    }
}