using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Features.Commands.Update;

public class FeatureUpdateCommandHandler(IFeatureRepository featureRepository, IMapper mapper)
    : IRequestHandler<FeatureUpdateCommand, string>
{
    public async Task<string> Handle(FeatureUpdateCommand request, CancellationToken cancellationToken)
    {
        await featureRepository.UpdateAsync(
            mapper.Map(request,
                await featureRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Feature is not found")),
            cancellationToken: cancellationToken);
        return $"Feature {request.Title} is updated.";
    }
}