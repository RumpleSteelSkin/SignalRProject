using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Baskets.Queries.GetCount;

public class BasketGetCountQueryHandler(IBasketRepository basketRepository) : IRequestHandler<BasketGetCountQuery, int>
{
    public async Task<int> Handle(BasketGetCountQuery request, CancellationToken cancellationToken)
    {
        return await basketRepository.CountAsync(cancellationToken: cancellationToken);
    }
}