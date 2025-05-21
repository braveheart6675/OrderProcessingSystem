using Microsoft.EntityFrameworkCore;
using OrderProcessingSystem.Domain.Entities;

public class ProductRepository : IProductRepository
{
    private readonly OrderDbContext _context;

    public ProductRepository(OrderDbContext context) => _context = context;

    public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.ToListAsync();
    public async Task<Product?> GetByIdAsync(Guid id) => await _context.Products.FindAsync(id);
    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid id) => await _context.Products.AnyAsync(p => p.Id == id);
}
