using Investments.Core.Messages;

namespace Investments.Core.Messages;

public interface IMediatorHandler
{
    Task PublishEventAsync<T>(T @event) where T : Event;
    Task PublishNotificationAsync<T>(T notification) where T : DomainNotificationEvent;
    Task<bool> SendCommandAsync<T>(T command) where T : Command;
}