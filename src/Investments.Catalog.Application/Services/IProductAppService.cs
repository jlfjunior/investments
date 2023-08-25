using Investments.Catalog.Application.Requests;
using Investments.Catalog.Application.Responses;

namespace Investments.Catalog.Application.Services;

public interface IProductAppService
{
    Task<ProductResponse> CreateAsync(ProductRequest productRequest);
}