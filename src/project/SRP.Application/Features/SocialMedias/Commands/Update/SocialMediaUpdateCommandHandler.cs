using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.SocialMedias.Commands.Update;

public class SocialMediaUpdateCommandHandler(ISocialMediaRepository socialMediaRepository, IMapper mapper)
    : IRequestHandler<SocialMediaUpdateCommand, string>
{
    public async Task<string> Handle(SocialMediaUpdateCommand request, CancellationToken cancellationToken)
    {
        await socialMediaRepository.UpdateAsync(
            mapper.Map(request,
                await socialMediaRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Social Media is not found")),
            cancellationToken: cancellationToken);
        return $"Social Media {request.Title} is updated.";
    }
}