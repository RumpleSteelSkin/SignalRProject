using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetAllWithCategoryName;

public class ProductGetAllWithCategoryNameQueryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<ProductGetAllWithCategoryNameQuery,
        ICollection<ProductGetAllWithCategoryNameQueryResponseDto>>
{
    public async Task<ICollection<ProductGetAllWithCategoryNameQueryResponseDto>> Handle(
        ProductGetAllWithCategoryNameQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<ProductGetAllWithCategoryNameQueryResponseDto>>(
            await productRepository.GetAllAsync(enableTracking: false, cancellationToken: cancellationToken));
    }
}