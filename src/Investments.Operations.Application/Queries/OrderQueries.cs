using Investments.Operations.Application.Queries.Models;
using Investments.Operations.Domain.Repositories;

namespace Investments.Operations.Application.Queries;

public class OrderQueries : IOrderQueries
{
    private readonly IOrderRepository _orderRepository;

    public OrderQueries(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<OrderModel> GetOrderAsync(Guid id)
    {
        var order = await _orderRepository.GetAsync(id);

        var model = new OrderModel();
        
        return model;
    }
}