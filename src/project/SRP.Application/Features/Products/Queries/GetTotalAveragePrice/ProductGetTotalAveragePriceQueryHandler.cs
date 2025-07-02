using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetTotalAveragePrice;

public class ProductGetTotalAveragePriceQueryHandler(IProductRepository productRepository)
    : IRequestHandler<ProductGetTotalAveragePriceQuery, decimal>
{
    public async Task<decimal> Handle(ProductGetTotalAveragePriceQuery request, CancellationToken cancellationToken)
    {
        return (await productRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken)).Select(x => x.Price).Average();
    }
}