using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Features.Queries.GetById;

public class FeatureGetByIdQueryHandler(IMapper mapper, IFeatureRepository featureRepository)
    : IRequestHandler<FeatureGetByIdQuery, FeatureGetByIdQueryResponseDto>
{
    public async Task<FeatureGetByIdQueryResponseDto> Handle(FeatureGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<FeatureGetByIdQueryResponseDto>(await featureRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}