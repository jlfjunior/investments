using Investments.Core.Messages;

namespace Investments.Core.DomainObjects;

public class DomainEvent : Event
{
    public DateTime Timestamp { get; private set; }
    
    public DomainEvent(Guid aggregateId) 
        : base(aggregateId)
    {
        Timestamp = DateTime.Now;
    }
}