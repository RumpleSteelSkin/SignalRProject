using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Discounts.Queries.GetCount;

public class DiscountGetCountQueryHandler(IDiscountRepository discountRepository)
    : IRequestHandler<DiscountGetCountQuery, int>
{
    public async Task<int> Handle(DiscountGetCountQuery request, CancellationToken cancellationToken)
    {
        return await discountRepository.CountAsync(cancellationToken: cancellationToken);
    }
}