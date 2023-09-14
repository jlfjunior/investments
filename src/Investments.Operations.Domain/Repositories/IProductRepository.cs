using Investments.Operations.Domain.Entities;

namespace Investments.Operations.Domain.Repositories;

public interface IProductRepository
{
    Task AddAsync(Product product);
    Task<Product> GetAsync(Guid id);
}