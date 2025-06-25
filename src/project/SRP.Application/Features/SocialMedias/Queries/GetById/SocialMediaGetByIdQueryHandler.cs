using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.SocialMedias.Queries.GetById;

public class SocialMediaGetByIdQueryHandler(ISocialMediaRepository socialMediaRepository, IMapper mapper)
    : IRequestHandler<SocialMediaGetByIdQuery, SocialMediaGetByIdQueryResponseDto>
{
    public async Task<SocialMediaGetByIdQueryResponseDto> Handle(SocialMediaGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<SocialMediaGetByIdQueryResponseDto>(await socialMediaRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}