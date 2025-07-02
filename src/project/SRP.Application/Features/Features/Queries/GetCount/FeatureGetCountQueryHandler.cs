using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Features.Queries.GetCount;

public class FeatureGetCountQueryHandler(IFeatureRepository featureRepository)
    : IRequestHandler<FeatureGetCountQuery, int>
{
    public async Task<int> Handle(FeatureGetCountQuery request, CancellationToken cancellationToken)
    {
        return await featureRepository.CountAsync(cancellationToken: cancellationToken);
    }
}