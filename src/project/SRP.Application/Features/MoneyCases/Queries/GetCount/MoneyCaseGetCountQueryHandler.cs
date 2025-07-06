using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Queries.GetCount;

public class MoneyCaseGetCountQueryHandler(IMoneyCaseRepository moneyCaseRepository) : IRequestHandler<MoneyCaseGetCountQuery, int>
{
    public async Task<int> Handle(MoneyCaseGetCountQuery request, CancellationToken cancellationToken)
    {
        return await moneyCaseRepository.CountAsync(cancellationToken: cancellationToken);
    }
}