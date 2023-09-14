using Investments.Core.DomainObjects;

namespace Investments.Operations.Domain.Entities;

public class Product : Entity, IAggregateRoot
{
    public bool IsClosedForPurchase { get; private set; }
    public bool IsClosedForWithdraw { get; private set; }

    public Product(bool isClosedForPurchase, bool isClosedForWithdraw)
    {
        IsClosedForPurchase = isClosedForPurchase;
        IsClosedForWithdraw = isClosedForWithdraw;
        
        IsValid();
    }
    
    protected override void IsValid()
    {
    }
}