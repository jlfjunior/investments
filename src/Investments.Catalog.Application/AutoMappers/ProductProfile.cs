using AutoMapper;
using Investments.Catalog.Application.Responses;
using Investments.Catalog.Domain.Entities;

namespace Investments.Catalog.Application.AutoMappers;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductResponse>();
    }
}