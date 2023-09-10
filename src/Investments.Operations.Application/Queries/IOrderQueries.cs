using Investments.Operations.Application.Queries.Models;

namespace Investments.Operations.Application.Queries;

public interface IOrderQueries
{
    Task<OrderModel> GetOrderAsync(Guid id);
}