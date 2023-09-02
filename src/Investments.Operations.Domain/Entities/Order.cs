using System.Collections.ObjectModel;
using Investments.Core.DomainObjects;

namespace Investments.Operations.Domain.Entities;

public class Order : Entity, IAggregateRoot
{
    public Guid ProductId { get; private set; }
    public decimal Amount { get; private set; }
    public decimal Quantity { get; private set; }
    public DateTime OperatedAt { get; private set; }
    
    private IList<Operation> _operations { get; set; }
    public IReadOnlyCollection<Operation> Operations 
        => _operations.ToList();

    protected Order()
    {
        _operations = new Collection<Operation>();
    }

    public Order(Guid productId, DateTime operatedAt)
    {
        ProductId = productId;
        OperatedAt = operatedAt;
    }

    public void AddOperation(Operation operation)
    {
        operation.AssignOrder(Id);
        _operations.Add(operation);
    }

    protected override void IsValid()
    {
    }
}