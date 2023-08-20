using Investments.Core.DomainObjects;

namespace Investments.Catalog.Domain;

public class Quote : Entity
{
    public Guid ProductId { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }
    public Product Product { get; private set; }
    
    public Quote(Product product, DateTime date, decimal value)
    {
        Product = product;
        ProductId = product.Id;
        Date = date;
        Value = value;
        
        IsValid();
    }

    protected override void IsValid()
    {
        Validations.IsEmpty(ProductId);
        Validations.LessOrEqualThanZero(Value);
    }
}