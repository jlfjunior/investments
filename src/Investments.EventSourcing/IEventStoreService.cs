using EventStore.ClientAPI;

namespace Investments.EventSourcing;

public interface IEventStoreService
{
    IEventStoreConnection GetConnection();
}