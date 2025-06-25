using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Features.Queries.GetAll;

public class FeatureGetAllQueryHandler(IMapper mapper, IFeatureRepository featureRepository)
    : IRequestHandler<FeatureGetAllQuery, ICollection<FeatureGetAllQueryResponseDto>>
{
    public async Task<ICollection<FeatureGetAllQueryResponseDto>> Handle(FeatureGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<FeatureGetAllQueryResponseDto>>(
            await featureRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}