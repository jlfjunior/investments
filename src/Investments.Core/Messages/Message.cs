namespace Investments.Core.Messages;

public abstract class Message
{
    public Guid AggregateId { get; set; }
    public string Type { get; set; }

    public Message()
    {
        Type = GetType().Name;
    }
}