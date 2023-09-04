using Investments.Core.DomainObjects;

namespace Investments.Catalog.Domain.Events;

public class QuoteProductUpdated : DomainEvent
{
    public DateTime Date { get; set; }
    public decimal Value { get; set; }

    public QuoteProductUpdated(Guid aggregateId, DateTime date, decimal value)
        : base(aggregateId)
    {
        AggregateId = aggregateId;
        Date = date;
        Value = value;
    }
}