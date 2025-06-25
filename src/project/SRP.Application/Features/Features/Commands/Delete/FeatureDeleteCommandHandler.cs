using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Features.Commands.Delete;

public class FeatureDeleteCommandHandler(IFeatureRepository featureRepository)
    : IRequestHandler<FeatureDeleteCommand, string>
{
    public async Task<string> Handle(FeatureDeleteCommand request, CancellationToken cancellationToken)
    {
        await featureRepository.HardDeleteAsync(
            await featureRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Feature not found."), cancellationToken: cancellationToken);
        return "Feature is deleted.";
    }
}