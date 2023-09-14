using Investments.Core.Messages.IntegrationEvents;
using MediatR;

namespace Investments.Operations.Application.Events;

public class ProductUpdatedEventHandler : INotificationHandler<ProductUpdatedEvent>
{
    public Task Handle(ProductUpdatedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}