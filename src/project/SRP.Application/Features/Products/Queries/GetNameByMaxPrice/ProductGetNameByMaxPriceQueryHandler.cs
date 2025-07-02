using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Products.Queries.GetNameByMaxPrice;

public class ProductGetNameByMaxPriceQueryHandler(IProductRepository productRepository)
    : IRequestHandler<ProductGetNameByMaxPriceQuery, string>
{
    public async Task<string> Handle(ProductGetNameByMaxPriceQuery request, CancellationToken cancellationToken)
    {
        return (await productRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken)).OrderByDescending(p => p.Price).First().Name;
    }
}