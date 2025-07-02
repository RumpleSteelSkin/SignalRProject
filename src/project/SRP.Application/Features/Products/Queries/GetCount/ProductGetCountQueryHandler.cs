using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetCount;

public class ProductGetCountQueryHandler(IProductRepository productRepository) : IRequestHandler<ProductGetCountQuery, int>
{
    public async Task<int> Handle(ProductGetCountQuery request, CancellationToken cancellationToken)
    {
        return await productRepository.CountAsync(cancellationToken: cancellationToken);
    }
}