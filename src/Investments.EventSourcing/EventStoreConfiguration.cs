using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Investments.EventSourcing;

public class EventStoreConfiguration : IConfigureOptions<EventStoreOptions>
{
    private readonly IConfiguration _configuration;
    private const string Section = "ConnectionString:EventStore";   
    public EventStoreConfiguration(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void Configure(EventStoreOptions options)
    {
        _configuration.GetSection(Section)
            .Bind(options);
    }
}