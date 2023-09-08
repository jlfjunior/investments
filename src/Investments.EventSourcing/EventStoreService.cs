using EventStore.ClientAPI;
using Microsoft.Extensions.Options;

namespace Investments.EventSourcing;

public class EventStoreService : IEventStoreService
{
    private readonly IEventStoreConnection _connection;
    private EventStoreOptions _options;

    public EventStoreService(IOptions<EventStoreOptions> options)
    {
        _options = options.Value;
        _connection = EventStoreConnection.Create(_options.Connection);
        _connection.ConnectAsync();   
    }
    
    public IEventStoreConnection GetConnection() => _connection;
}