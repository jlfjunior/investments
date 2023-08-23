namespace Investments.Core.DomainObjects;

public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid();
        DomainEvents = new List<DomainEvent>();
    }
    
    public Guid Id { get; set; }
    
    public ICollection<DomainEvent> DomainEvents { get; private set; }

    public void AddEvent(DomainEvent domainEvent)
    {
        DomainEvents.Add(domainEvent); 
    }
    
    protected abstract void IsValid();
}