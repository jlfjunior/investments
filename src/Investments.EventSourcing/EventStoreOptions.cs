using Microsoft.Extensions.Options;

namespace Investments.EventSourcing;

public class EventStoreOptions
{
    public string Connection { get; set; }
}