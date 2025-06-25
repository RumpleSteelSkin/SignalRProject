using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.SocialMedias.Queries.GetAll;

public class SocialMediaGetAllQueryHandler(ISocialMediaRepository socialMediaRepository, IMapper mapper)
    : IRequestHandler<SocialMediaGetAllQuery, ICollection<SocialMediaGetAllQueryResponseDto>>
{
    public async Task<ICollection<SocialMediaGetAllQueryResponseDto>> Handle(SocialMediaGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<SocialMediaGetAllQueryResponseDto>>(
            await socialMediaRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}