namespace Investments.Core.Data.EventSourcing;

public class StoredEvent
{
    public StoredEvent(Guid id, string type, DateTime date, string data)
    {
        Id = id;
        Type = type;
        Date = date;
        Data = data;
    }
    
    public Guid Id { get; private set; }
    public string Type { get; private set; }
    public DateTime Date { get; private set; }
    public string Data { get; private set; }
}