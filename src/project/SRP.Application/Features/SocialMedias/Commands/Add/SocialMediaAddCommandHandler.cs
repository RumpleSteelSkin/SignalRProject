using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.SocialMedias.Commands.Add;

public class SocialMediaAddCommandHandler(ISocialMediaRepository socialMediaRepository, IMapper mapper)
    : IRequestHandler<SocialMediaAddCommand, string>
{
    public async Task<string> Handle(SocialMediaAddCommand request, CancellationToken cancellationToken)
    {
        await socialMediaRepository.AddAsync(mapper.Map<SocialMedia>(request), cancellationToken: cancellationToken);
        return $"Product {request.Title} is added.";
    }
}