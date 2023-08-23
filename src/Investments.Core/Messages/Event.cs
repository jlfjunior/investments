using MediatR;

namespace Investments.Core.Messages;

public abstract class Event : INotification
{
    public Guid AggregateId { get; set; }
    
    protected Event(Guid aggregateId)
    {
        AggregateId = aggregateId;
    }
}