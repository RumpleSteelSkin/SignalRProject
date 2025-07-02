using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.SocialMedias.Queries.GetCount;

public class SocialMediaGetCountQueryHandler(ISocialMediaRepository socialMediaRepository)
    : IRequestHandler<SocialMediaGetCountQuery, int>
{
    public async Task<int> Handle(SocialMediaGetCountQuery request, CancellationToken cancellationToken)
    {
        return await socialMediaRepository.CountAsync(cancellationToken: cancellationToken);
    }
}