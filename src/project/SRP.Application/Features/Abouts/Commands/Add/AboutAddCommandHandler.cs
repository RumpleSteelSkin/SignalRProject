using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Abouts.Commands.Add;

public class AboutAddCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
    : IRequestHandler<AboutAddCommand, string>
{
    public async Task<string> Handle(AboutAddCommand request, CancellationToken cancellationToken)
    {
        await aboutRepository.AddAsync(mapper.Map<About>(request), cancellationToken);
        return $"About {request.Title} has been successfully added.";
    }
}