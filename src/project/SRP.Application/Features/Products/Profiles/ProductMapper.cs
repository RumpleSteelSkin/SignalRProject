using AutoMapper;
using SRP.Application.Features.Products.Commands.Add;
using SRP.Application.Features.Products.Commands.Update;
using SRP.Application.Features.Products.Queries.GetAll;
using SRP.Application.Features.Products.Queries.GetAllWithCategoryName;
using SRP.Application.Features.Products.Queries.GetAllWithNotNullImageAndCategoryNames;
using SRP.Application.Features.Products.Queries.GetById;
using SRP.Domain.Models;

namespace SRP.Application.Features.Products.Profiles;

public class ProductMapper : Profile
{
    public ProductMapper()
    {
        CreateMap<ProductAddCommand, Product>();
        CreateMap<ProductUpdateCommand, Product>();
        CreateMap<Product, ProductGetAllQueryResponseDto>();
        CreateMap<Product, ProductGetByIdQueryResponseDto>();
        CreateMap<Product, ProductGetAllWithCategoryNameQueryResponseDto>();
        CreateMap<Product, ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto>();
    }
}