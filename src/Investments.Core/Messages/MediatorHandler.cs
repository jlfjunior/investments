using Investments.Core.Data.EventSourcing;
using Investments.Core.Messages;
using MediatR;

namespace Investments.Core.Messages;

/// <summary>
/// MediatorHandler works as a service bus to application, but it isn't a bus proper
/// </summary>
public class MediatorHandler : IMediatorHandler
{
    private readonly IMediator _mediator;
    private readonly IEventSourcingRepository _eventSourcingRepository;

    public MediatorHandler(IMediator mediator, IEventSourcingRepository eventSourcingRepository)
    {
        _mediator = mediator;
        _eventSourcingRepository = eventSourcingRepository;
    }
    
    public async Task PublishEventAsync<T>(T @event) where T : Event
    {
        await _mediator.Publish(@event);
        await _eventSourcingRepository.SaveEvent(@event);
    }

    public async Task PublishNotificationAsync<T>(T notification) where T : DomainNotificationEvent
    {
        await _mediator.Publish(notification);
    }

    public async Task<bool> SendCommandAsync<T>(T command) where T : Command
    {
        return await _mediator.Send(command);
    }
}