using MediatR;

namespace Investments.Core.Messages;

public class DomainNotificationEvent : Message, INotification
{
    public DateTime Timestamp { get; set; }
    public Guid Id { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public int Version { get; set; }
}

public class DomainNotificationhandler : INotificationHandler<DomainNotificationEvent>
{
    private List<DomainNotificationEvent> _notifications;
    
    public Task Handle(DomainNotificationEvent notificationEvent, CancellationToken cancellationToken)
    {
        _notifications.Add(notificationEvent);
        
        return Task.CompletedTask;
    }

    public IList<DomainNotificationEvent> GetNotifications() => _notifications;
}