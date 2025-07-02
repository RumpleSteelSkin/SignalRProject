using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Abouts.Queries.GetCount;

public class AboutGetCountQueryHandler(IAboutRepository aboutRepository) : IRequestHandler<AboutGetCountQuery, int>
{
    public async Task<int> Handle(AboutGetCountQuery request, CancellationToken cancellationToken)
    {
        return await aboutRepository.CountAsync(cancellationToken: cancellationToken);
    }
}