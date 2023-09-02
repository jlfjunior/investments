using Investments.Operations.Domain.Entities;
using Investments.Operations.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Investments.Operations.Application.Commands.CreateOperation;

public class CreateOperationCommandHandler : IRequestHandler<CreateOperationCommand, bool>
{
    private readonly ILogger<CreateOperationCommandHandler> _looger;
    private IOrderRepository _orderRepository;

    public CreateOperationCommandHandler(ILogger<CreateOperationCommandHandler> looger, IOrderRepository orderRepository)
    {
        _looger = looger;
        _orderRepository = orderRepository;
    }

    public async Task<bool> Handle(CreateOperationCommand request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.GetAsync(request.OrderId);
        var operation = new Operation((int)request.Quantity, request.UnitPrice);
        
        operation.AssignOrder(order.Id);
        order.AddOperation(operation);
        
        _orderRepository.Update(order);

        return true;
    }
}