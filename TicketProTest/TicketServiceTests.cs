using Microsoft.EntityFrameworkCore;
using NSubstitute;
using TicketPro.Data;
using TicketPro.Data.Models;

namespace TicketProTest;

[TestFixture]
public class TicketServiceTests
{
    private DbSet<Ticket> _mockDbSet;
    private List<Ticket> _ticketList;
    private IQueryable<Ticket> _data;
    private ApplicationDbContext _mockContext;
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
        _mockContext = Substitute.For<ApplicationDbContext>();
        _mockContext.Set<Ticket>().Returns(_mockDbSet);
        _mockContext.Tickets.Returns(_mockDbSet);
        _mockDbSet.Add(Arg.Do<Ticket>(ticket =>
        {
            _ticketList.Add(ticket);
            _data = _ticketList.AsQueryable();
        }));
    }

    [Test]
    public void Test1()
    {
        

        
        Assert.Pass();
    }
}