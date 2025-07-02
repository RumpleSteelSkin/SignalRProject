using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetNameByMinPrice;

public class ProductGetNameByMinPriceQueryHandler(IProductRepository productRepository)
    : IRequestHandler<ProductGetNameByMinPriceQuery, string>
{
    public async Task<string> Handle(ProductGetNameByMinPriceQuery request, CancellationToken cancellationToken)
    {
        return (await productRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken)).OrderBy(p => p.Price).First().Name;
    }
}