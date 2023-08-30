namespace Investments.Core.DomainObjects;

public sealed class CNPJ
{
    public string Value { get; init; }

    public CNPJ(string value)
    {
        Validations.IsNullOrEmpty(value);

        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;

        var other = (CNPJ)obj;

        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public static bool operator ==(CNPJ left, CNPJ right)
        => EqualOperator(left, right);

    public static bool operator !=(CNPJ left, CNPJ right)
        => EqualOperator(left, right);

    private static bool EqualOperator(CNPJ left, CNPJ right)
    {
        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return ReferenceEquals(left, right) || left.Equals(right);
    }

    private static bool NotEqualOperator(CNPJ left, CNPJ right)
    {
        return !EqualOperator(left, right);
    }

    private IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}