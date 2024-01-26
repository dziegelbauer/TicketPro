using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using TicketPro.Data;
using TicketPro.Data.Models;
using TicketPro.DTO;
using TicketPro.Exceptions;
using TicketPro.Services;

namespace TicketProTest;

[TestFixture]
public class TicketServiceTests
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly UserManager<ApplicationUser> _userManager;

    public TicketServiceTests()
    {
        var userStore = Substitute.For<IUserStore<ApplicationUser>>();
        _userManager = Substitute.For<UserManager<ApplicationUser>>(userStore,null,null,null,null,null,null,null,null);
        _dbContextFactory = Substitute.For<IDbContextFactory<ApplicationDbContext>>();
    }
    
    [SetUp]
    public async Task Setup()
    {
        var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: $"ticketprotest_{Guid.NewGuid()}")
            .Options;
        
        _dbContextFactory.CreateDbContextAsync().Returns(new ApplicationDbContext(dbContextOptions));

        _userManager.FindByNameAsync(Arg.Is("abc"))
            .Returns(new ApplicationUser
            {
                Id = "567"
            });

        _userManager.FindByIdAsync(Arg.Is("567"))
            .Returns(new ApplicationUser
            {
                Id = "567"
            });

        _userManager.GetUsersInRoleAsync(Arg.Is("TECHNICIAN"))
            .Returns(new []
            {
                new ApplicationUser
                {
                    Id = "567",
                    ChargeableRate = 44.0M
                }
            });

        var dbContext = await _dbContextFactory.CreateDbContextAsync();

        await dbContext.Customers.AddAsync(new Customer
        {
            Id = 1,
            Name = "test customer"
        });

        await dbContext.Users.AddAsync(new ApplicationUser
        {
            Id = "567",
            ChargeableRate = 44.0M
        });

        await dbContext.Tickets.AddAsync(new Ticket
        {
            Id = 1,
            AssignedToId = "567",
            Created = DateTime.Now,
            Status = TicketStatus.Closed,
            CreatorId = "567",
            Title = "Test Ticket",
            Description = "Some text",
            CustomerId = 1,
            BillableHours = 5
        });
        await dbContext.Tickets.AddAsync(new Ticket
        {
            Id = 5,
            AssignedToId = "567",
            Created = DateTime.Now,
            Status = TicketStatus.Closed,
            CreatorId = "567",
            Title = "Test Ticket",
            Description = "Some text",
            CustomerId = 1,
            BillableHours = 15
        });
        await dbContext.SaveChangesAsync();
    }

    [Test]
    public async Task CreateTicketAsyncAddsRecordWithValidId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var creationRequest = new CreateTicketDto
        {
            CustomerId = 1,
            Creator = "abc",
            AssignedToId = null,
            Description = "This is a test",
            Status = TicketStatus.Open,
            Title = "Test Ticket 1"
        };

        var ticket = await ticketService.CreateTicketAsync(creationRequest);
        
        Assert.That(ticket.CreatorId, Is.EqualTo("567"));
    }

    [Test]
    public void CreateTicketAsyncThrowsWithNullUserId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var creationRequest = new CreateTicketDto
        {
            CustomerId = 1,
            Creator = null,
            AssignedToId = null,
            Description = "This is a test",
            Status = TicketStatus.Open,
            Title = "Test Ticket 1"
        };

        Assert.That(
            async () => await ticketService.CreateTicketAsync(creationRequest), 
            Throws.TypeOf<NullUserException>());
    }
    
    [Test]
    public void CreateTicketAsyncThrowsWithInvalidUserId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var creationRequest = new CreateTicketDto
        {
            CustomerId = 1,
            Creator = "def",
            AssignedToId = null,
            Description = "This is a test",
            Status = TicketStatus.Open,
            Title = "Test Ticket 1"
        };

        Assert.That(
            async () => await ticketService.CreateTicketAsync(creationRequest), 
            Throws.TypeOf<UserNotFoundException>());
    }

    [Test]
    public async Task GetTicketByIdAsyncReturnsRecordWithValidId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var ticket = await ticketService.GetTicketByIdAsync(1);
        
        Assert.That(ticket, Is.Not.Null);
    }
    
    [Test]
    public void GetTicketByIdAsyncReturnsThrowsWithInvalidId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        Assert.That(
            async () => await ticketService.GetTicketByIdAsync(2),
            Throws.TypeOf<TicketNotFoundException>());
    }

    [Test]
    public void UpdateTicketAsyncUpdatesTicketWithValidArguments()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var updateRequest = new UpdateTicketDto
        {
            Id = 1,
            AssignedToId = "567",
            Status = TicketStatus.Assigned,
            Title = "Test Ticket",
            Description = "Some text",
            CustomerId = 1,
            Modifier = "abc"
        };

        Assert.That(
            async () => await ticketService.UpdateTicketAsync(updateRequest),
            Throws.Nothing);
    }
    
    [Test]
    public void UpdateTicketAsyncThrowsWithInvalidTicket()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var updateRequest = new UpdateTicketDto
        {
            Id = 2,
            AssignedToId = "567",
            Status = TicketStatus.Assigned,
            Title = "Test Ticket",
            Description = "Some text",
            CustomerId = 1,
            Modifier = "abc"
        };

        Assert.That(
            async () => await ticketService.UpdateTicketAsync(updateRequest),
            Throws.TypeOf<TicketNotFoundException>());
    }
    
    [Test]
    public void UpdateTicketAsyncThrowsWithInvalidUser()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var updateRequest = new UpdateTicketDto
        {
            Id = 1,
            AssignedToId = "567",
            Status = TicketStatus.Assigned,
            Title = "Test Ticket",
            Description = "Some text",
            CustomerId = 1,
            Modifier = "def"
        };

        Assert.That(
            async () => await ticketService.UpdateTicketAsync(updateRequest),
            Throws.TypeOf<UserNotFoundException>());
    }

    [Test]
    public void DeleteTicketAsyncSucceedsWithValidId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);
        Assert.Multiple(() =>
        {
            Assert.That(
                async () => await ticketService.DeleteTicketAsync(5),
                Throws.Nothing);

            Assert.That(
                async () => await ticketService.GetTicketByIdAsync(5),
                Throws.TypeOf<TicketNotFoundException>());
        });
    }
    
    [Test]
    public void DeleteTicketAsyncThrowsWithInvalidId()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        Assert.That(
            async () => await ticketService.DeleteTicketAsync(2),
            Throws.TypeOf<TicketNotFoundException>());
    }

    [Test]
    public async Task GetTechnicianRevenueDataAsyncCalculatesCorrectly()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var data = await ticketService.GetTechnicianRevenueDataAsync();
        
        Assert.That(data, Has.Exactly(1).Items);
        Assert.That(data[0].TotalRevenue, Is.EqualTo(880M));
    }

    [Test]
    public async Task GetCustomerRevenueDataAsyncCalculatesCorrectly()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var data = await ticketService.GetCustomerRevenueDataAsync();
        
        Assert.That(data, Has.Exactly(1).Items);
        Assert.That(data[0].TotalRevenue, Is.EqualTo(880M));
    }

    [Test]
    public async Task GetTicketStatusDataAsyncReturnsGoodData()
    {
        var ticketService = new TicketService(_dbContextFactory, _userManager);

        var data = await ticketService.GetTicketStatusDataAsync();
        
        Assert.That(data, Has.Exactly(2).Items);
    }
}