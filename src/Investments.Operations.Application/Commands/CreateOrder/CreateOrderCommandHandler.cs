using Investments.Operations.Domain.Entities;
using Investments.Operations.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Investments.Operations.Application.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
{
    private readonly ILogger<CreateOrderCommandHandler> _logger;
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;

    public CreateOrderCommandHandler(ILogger<CreateOrderCommandHandler> logger, IOrderRepository orderRepository,
        IProductRepository productRepository)
    {
        _logger = logger;
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetAsync(request.ProductId);

        if (product == null) return false;

        var order = new Order(request.ProductId, request.OperationDate);

        _orderRepository.Add(order);

        _logger.LogInformation("OrderId:{orderId} registered successfully.", order.Id);

        return true;
    }
}