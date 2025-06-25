using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Features.Commands.Add;

public class FeatureAddCommandHandler(IFeatureRepository featureRepository, IMapper mapper)
    : IRequestHandler<FeatureAddCommand, string>
{
    public async Task<string> Handle(FeatureAddCommand request, CancellationToken cancellationToken)
    {
        await featureRepository.AddAsync(mapper.Map<Feature>(request), cancellationToken: cancellationToken);
        return $"Feature {request.Title} is added.";
    }
}