namespace Investments.Core.Messages;

public abstract class IntegrationEvent : Event
{
    protected IntegrationEvent(Guid aggregateId) : base(aggregateId)
    {
    }
}