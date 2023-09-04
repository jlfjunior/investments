using MediatR;

namespace Investments.Core.Messages;

public abstract class Event : Message, INotification
{
    protected Event(Guid aggregateId)
    {
        AggregateId = aggregateId;
    }
}