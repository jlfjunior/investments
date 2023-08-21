using Investments.Catalog.Domain.Repositories;
using Investments.Catalog.Domain.Entities;
using Investments.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Investments.Catalog.Infrastructure.Data;

public class ProductRepository : IProductRepository
{
    private readonly CatalogDbContext _dbContext;
    
    public ProductRepository(CatalogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IUnitOfWork UnitOfWork => _dbContext;
    
    public void Add(Product product)
    {
        _dbContext.Products.Add(product);
    }

    public void Update(Product product)
    {
        _dbContext.Products.Update(product);
    }

    public async Task<Product> FindAsync(Guid id)
    {
        return await _dbContext.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _dbContext.Products.ToListAsync();
    }

    public void Add(Quote quote)
    {
        _dbContext.Quotes.Add(quote);
    }
    
    public void Update(Quote quote)
    {
        _dbContext.Quotes.Update(quote);
    }

    public void Remove(Quote quote)
    {
        _dbContext.Quotes.Remove(quote);
    }
}