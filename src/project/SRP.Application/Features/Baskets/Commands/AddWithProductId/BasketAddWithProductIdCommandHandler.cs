using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Baskets.Commands.AddWithProductId;

public class BasketAddWithProductIdCommandHandler(
    IBasketRepository basketRepository,
    IProductRepository productRepository) : IRequestHandler<BasketAddWithProductIdCommand, string>
{
    public async Task<string> Handle(BasketAddWithProductIdCommand request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.ProductId, enableTracking: false, include: false,
            cancellationToken: cancellationToken);
        await basketRepository.AddAsync(new Basket()
        {
            Count = 1,
            MenuTableID = 3,
            Status = true,
            Price = product!.Price,
            ProductID = product.Id,
            TotalPrice = product.Price * 1
        }, cancellationToken: cancellationToken);
        return "Basket added with product Id: " + request.ProductId;
    }
}