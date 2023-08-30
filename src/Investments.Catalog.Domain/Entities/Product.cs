using Investments.Core.DomainObjects;

namespace Investments.Catalog.Domain.Entities;

public class Product : Entity, IAggregateRoot
{
    public CNPJ CNPJ { get; init; }
    public string Name { get; private set; }
    public string Symbol { get; private set; }
    public bool IsEnabled { get; private set; }
    public DateTime CreatedAt { get; private set; }
    
    public ICollection<Quote> Quotes { get; private set; }

    protected Product() { }

    public Product(string cnpj, string name, string symbol)
    {
        CNPJ = new CNPJ(cnpj);
        Name = name;
        Symbol = symbol;
        CreatedAt = DateTime.Now;
        
        IsValid();
    }

    public void Enable() => IsEnabled = true;
    
    public void Disable() => IsEnabled = false;

    protected override void IsValid()
    {
        Validations.IsNullOrEmpty(Name);
        Validations.IsNullOrEmpty(Symbol);
    }
}