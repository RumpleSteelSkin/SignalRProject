using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Abouts.Queries.GetAll;

public class AboutGetAllQueryHandler(IAboutRepository aboutRepository, IMapper mapper)
    : IRequestHandler<AboutGetAllQuery, ICollection<AboutGetAllQueryResponseDto>>
{
    public async Task<ICollection<AboutGetAllQueryResponseDto>> Handle(AboutGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<AboutGetAllQueryResponseDto>>(
            await aboutRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}