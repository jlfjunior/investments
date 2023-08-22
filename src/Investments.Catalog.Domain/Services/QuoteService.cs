using Investments.Catalog.Domain.Entities;
using Investments.Catalog.Domain.Repositories;

namespace Investments.Catalog.Domain.Services;

public class QuoteService : IQuoteService
{
    private readonly IProductRepository _productRepository;

    public QuoteService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<bool> RegisterQuoteAsync(Guid productId, DateTime date, decimal value)
    {
        var product = await _productRepository.FindAsync(productId);
        var quote = await _productRepository.FindAsync(productId, date);

        if (quote == null)
        {
            quote = new Quote(product, date, value);
            _productRepository.Add(quote);
        }
        else
        {
            quote.UpdateValue(value);
            _productRepository.Update(quote);
        }
        
        return await _productRepository.UnitOfWork.CommitAsync();
    }
}