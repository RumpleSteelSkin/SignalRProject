using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetCountWithCategoryName;

public class ProductGetCountWithCategoryNameHandler(IProductRepository productRepository)
    : IRequestHandler<ProductGetCountWithCategoryName, int>
{
    public async Task<int> Handle(ProductGetCountWithCategoryName request, CancellationToken cancellationToken)
    {
        return await productRepository.CountAsync(
            x => x.Category != null && request.CategoryName != null && x.Category.Name.Contains(request.CategoryName),
            cancellationToken: cancellationToken);
    }
}