using Microsoft.EntityFrameworkCore;
using OrderProcessingSystem.Domain.Entities;
using OrderService.Domain.Entities;

public class OrderDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderEvent> OrderEvents => Set<OrderEvent>();

    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
