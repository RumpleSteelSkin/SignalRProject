using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetAllWithNotNullImageAndCategoryNames;

public class ProductGetAllWithNotNullImageAndCategoryNamesQueryHandler(
    IProductRepository productRepository,
    IMapper mapper)
    : IRequestHandler<ProductGetAllWithNotNullImageAndCategoryNamesQuery,
        ICollection<ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto>>
{
    public async Task<ICollection<ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto>> Handle(
        ProductGetAllWithNotNullImageAndCategoryNamesQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<ProductGetAllWithNotNullImageAndCategoryNamesQueryResponseDto>>(
            await productRepository.GetAllAsync(
                filter: p =>
                    p.ImageUrl != null && p.Category != null && request.CategoryNames != null &&
                    request.CategoryNames.Contains(p.Category.Name), enableTracking: false, include: true,
                cancellationToken: cancellationToken));
    }
}