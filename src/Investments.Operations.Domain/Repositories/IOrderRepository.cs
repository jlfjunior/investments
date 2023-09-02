using Investments.Operations.Domain.Entities;

namespace Investments.Operations.Domain.Repositories;

public interface IOrderRepository
{
    Task<Order> GetAsync(Guid id);
    void Add(Order order);
    void Update(Order order);
}