using Investments.Core.Messages;

namespace Investments.Core.Data.EventSourcing;

public interface IEventSourcingRepository
{
    Task SaveEvent<T>(T @event) where T : Event;
    Task<IEnumerable<StoredEvent>> GetStoredEvents<T>(Guid aggregateId);
}