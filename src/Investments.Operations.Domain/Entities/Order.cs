using Investments.Core.DomainObjects;

namespace Investments.Operations.Domain.Entities;

public class Order : Entity, IAggregateRoot
{
    public Guid ProductId { get; private set; }
    public decimal Amount { get; private set; }
    public decimal Quantity { get; private set; }
    public DateTime OperatedAt { get; private set; }

    protected Order() { }

    public Order(Guid productId, decimal amount, decimal quantity, DateTime operatedAt)
    {
        ProductId = productId;
        Amount = amount;
        Quantity = quantity;
        OperatedAt = operatedAt;
    }

    protected override void IsValid()
    {
    }
}