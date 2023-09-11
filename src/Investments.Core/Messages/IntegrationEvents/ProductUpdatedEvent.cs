namespace Investments.Core.Messages.IntegrationEvents;

public class ProductUpdatedEvent : IntegrationEvent
{
    public ProductUpdatedEvent(Guid aggregateId, bool isClosedForPurchase, bool isClosedForWithdraw) 
        : base(aggregateId)
    {
        IsClosedForPurchase = isClosedForPurchase;
        IsClosedForWithdraw = isClosedForWithdraw;
    }

    public bool IsClosedForPurchase { get; set; }
    public bool IsClosedForWithdraw { get; set; }
}