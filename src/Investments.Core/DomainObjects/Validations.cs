namespace Investments.Core.DomainObjects;

public abstract class Validations
{
    public static void IsNullOrEmpty(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) 
            throw new DomainException("Value cannot be null, empty or white spaces.");
    }
    
    public static void IsEmpty(Guid value)
    {
        if (value == Guid.Empty) 
            throw new DomainException("Value cannot be empty.");
    }

    public static void LessOrEqualThanZero(decimal value)
    {
        if (value <= decimal.Zero) throw new DomainException("Value cannot be less or equals zero.");
    }
}