using System.Text;
using EventStore.ClientAPI;
using Investments.Core.Data.EventSourcing;
using Investments.Core.Messages;
using Newtonsoft.Json;

namespace Investments.EventSourcing;

public class EventSourcingRepository : IEventSourcingRepository
{
    private readonly IEventStoreService _eventStoreService;

    public EventSourcingRepository(IEventStoreService eventStoreService)
    {
        _eventStoreService = eventStoreService;
    }
    
    public async Task SaveEvent<T>(T @event) where T : Event
    {
        var records = FormatEvent(@event);
        
        await _eventStoreService.GetConnection()
            .AppendToStreamAsync(@event.AggregateId.ToString(), 
                ExpectedVersion.Any, 
                records);
    }

    public async Task<IEnumerable<StoredEvent>> GetStoredEvents<T>(Guid aggregateId)
    {
        var events = await _eventStoreService.GetConnection()
            .ReadStreamEventsBackwardAsync(aggregateId.ToString(), 0, 100, false);

        var list = new List<StoredEvent>();

        foreach (var item in events.Events)
        {
            
        }

        return list;
    }

    private static IEnumerable<EventData> FormatEvent<T>(T @event) where T : Event
    {
        yield return new EventData(Guid.NewGuid(),
            @event.Type,
            true,
            Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(@event)),
            null);
    }
}   