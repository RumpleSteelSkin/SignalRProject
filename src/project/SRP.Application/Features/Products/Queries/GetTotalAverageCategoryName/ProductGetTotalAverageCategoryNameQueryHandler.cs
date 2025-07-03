using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetTotalAverageCategoryName;

public class ProductGetTotalAverageCategoryNameQueryHandler(IProductRepository productRepository)
    : IRequestHandler<ProductGetTotalAverageCategoryNameQuery, decimal>
{
    public async Task<decimal> Handle(ProductGetTotalAverageCategoryNameQuery request,
        CancellationToken cancellationToken)
    {
        return (await productRepository.GetAllAsync(
            filter: x => x.Category != null && x.Category.Name == request.CategoryName, enableTracking: false,
            include: true,
            cancellationToken: cancellationToken)).Select(x => x.Price).Average();
    }
}