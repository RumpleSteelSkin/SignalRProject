using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MoneyCases.Queries.GetAll;

public class MoneyCaseGetAllQueryHandler(IMoneyCaseRepository moneyCaseRepository, IMapper mapper)
    : IRequestHandler<MoneyCaseGetAllQuery, ICollection<MoneyCaseGetAllQueryResponseDto>>
{
    public async Task<ICollection<MoneyCaseGetAllQueryResponseDto>> Handle(MoneyCaseGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<MoneyCaseGetAllQueryResponseDto>>(
            await moneyCaseRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}