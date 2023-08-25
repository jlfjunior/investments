using System.Runtime.InteropServices.JavaScript;
using Investments.Catalog.Domain.Entities;
using Investments.Core.Data;

namespace Investments.Catalog.Domain.Repositories;

public interface IProductRepository : IRepository<Product>
{
    void Add(Product product);
    void Update(Product product);
    Task<Product> FindAsync(Guid id);
    Task<bool> ExistAsync(string symbol);
    Task<IEnumerable<Product>> GetAllAsync();
    
    void Add(Quote quote);
    void Update(Quote quote);
    void Remove(Quote quote);
    Task<Quote> FindAsync(Guid productId, DateTime date);
}