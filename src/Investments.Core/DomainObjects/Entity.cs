namespace Investments.Core.DomainObjects;

public abstract class Entity
{
    public Guid Id { get; set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    protected abstract void IsValid();
}