using Investments.Core.DomainObjects;

namespace Investments.Operations.Domain.Entities;

public class Operation : Entity
{
    public Guid OrderId { get; private set; }
    public int ExecutedQuotes { get; private set; }
    public decimal UnitPrice { get; private set; }

    protected Operation() { }
    
    public Operation(int executedQuotes, decimal unitPrice)
    {
        ExecutedQuotes = executedQuotes;
        UnitPrice = unitPrice;
        
        IsValid();
    }

    public void AssignOrder(Guid orderId)
    {
        OrderId = orderId;
    }

    protected override void IsValid()
    {
        Validations.LessOrEqualThanZero(ExecutedQuotes);
        Validations.LessOrEqualThanZero(UnitPrice);
    }
}