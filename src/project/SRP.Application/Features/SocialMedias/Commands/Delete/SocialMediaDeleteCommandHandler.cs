using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.SocialMedias.Commands.Delete;

public class SocialMediaDeleteCommandHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
    : IRequestHandler<SocialMediaDeleteCommand, string>
{
    public async Task<string> Handle(SocialMediaDeleteCommand request, CancellationToken cancellationToken)
    {
        await socialMediaRepository.HardDeleteAsync(
            await socialMediaRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Social Media not found."), cancellationToken: cancellationToken);
        return "Social Media is deleted.";
    }
}