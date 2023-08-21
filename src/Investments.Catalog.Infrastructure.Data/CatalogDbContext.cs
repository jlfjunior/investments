using Investments.Catalog.Domain.Entities;
using Investments.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Investments.Catalog.Infrastructure.Data;

public class CatalogDbContext : DbContext, IUnitOfWork
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
        : base(options)
    { }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    
    public async Task<bool> CommitAsync()
    {
        return await this.SaveChangesAsync() > 0;
    }
}