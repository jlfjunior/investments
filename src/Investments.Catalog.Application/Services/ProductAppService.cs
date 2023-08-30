using AutoMapper;
using Investments.Catalog.Application.Requests;
using Investments.Catalog.Application.Responses;
using Investments.Catalog.Domain.Entities;
using Investments.Catalog.Domain.Repositories;
using Investments.Core.DomainObjects;

namespace Investments.Catalog.Application.Services;

public class ProductAppService : IProductAppService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductAppService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    
    public async Task<ProductResponse> CreateAsync(ProductRequest productRequest)
    {
        if (await _productRepository.ExistAsync(productRequest.Symbol)) 
            throw new DomainException("");

        var product = new Product(productRequest.CNPJ, productRequest.Name, productRequest.Symbol);

        _productRepository.Add(product);

        await _productRepository.UnitOfWork.CommitAsync();

        return _mapper.Map<ProductResponse>(product);
    }
}