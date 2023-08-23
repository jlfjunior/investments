using Investments.Core.DomainObjects;

namespace Investments.Catalog.Domain.Events;

public class QuoteProductCreated : DomainEvent
{
    public DateTime Date { get; set; }
    public decimal Value { get; set; }

    public QuoteProductCreated(Guid aggregateId, DateTime date, decimal value) 
        : base(aggregateId)
    {
        Date = date;
        Value = value;
    }
}