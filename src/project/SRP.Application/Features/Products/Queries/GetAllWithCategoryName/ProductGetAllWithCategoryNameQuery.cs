using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetAllWithCategoryName;

public class ProductGetAllWithCategoryNameQuery : IRequest<ICollection<ProductGetAllWithCategoryNameQueryResponseDto>>;

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

public class ProductGetAllWithCategoryNameQueryResponseDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public string? CategoryName { get; set; }
}