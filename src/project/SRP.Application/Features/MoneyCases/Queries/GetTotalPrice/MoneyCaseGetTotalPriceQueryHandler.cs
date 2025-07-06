using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Queries.GetTotalPrice;

public class MoneyCaseGetTotalPriceQueryHandler(IMoneyCaseRepository moneyCaseRepository)
    : IRequestHandler<MoneyCaseGetTotalPriceQuery, decimal>
{
    public async Task<decimal> Handle(MoneyCaseGetTotalPriceQuery request, CancellationToken cancellationToken)
    {
        return (await moneyCaseRepository.GetAllAsync(enableTracking: false, include: false,
            cancellationToken: cancellationToken)).OrderByDescending(p => p.Id).First().TotalAmount;
    }
}