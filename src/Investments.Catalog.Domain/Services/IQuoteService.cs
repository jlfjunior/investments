namespace Investments.Catalog.Domain.Services;

public interface IQuoteService
{
    Task<bool> RegisterQuoteAsync(Guid productId, DateTime date, decimal value);
}