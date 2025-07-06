using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Queries.GetById;

public class MoneyCaseGetByIdQueryHandler(IMoneyCaseRepository moneyCaseRepository, IMapper mapper)
    : IRequestHandler<MoneyCaseGetByIdQuery, MoneyCaseGetByIdQueryResponseDto>
{
    public async Task<MoneyCaseGetByIdQueryResponseDto> Handle(MoneyCaseGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<MoneyCaseGetByIdQueryResponseDto>(await moneyCaseRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}