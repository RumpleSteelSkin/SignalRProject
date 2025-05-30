using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Abouts.Queries.GetById;

public class AboutGetByIdQueryHandler(IAboutRepository aboutRepository, IMapper mapper)
    : IRequestHandler<AboutGetByIdQuery, AboutGetByIdQueryResponseDto>
{
    public async Task<AboutGetByIdQueryResponseDto> Handle(AboutGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<AboutGetByIdQueryResponseDto>(await aboutRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}