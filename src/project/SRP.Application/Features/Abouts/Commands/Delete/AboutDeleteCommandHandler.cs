using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Abouts.Commands.Delete;

public class AboutDeleteCommandHandler(IAboutRepository aboutRepository) : IRequestHandler<AboutDeleteCommand, string>
{
    public async Task<string> Handle(AboutDeleteCommand request, CancellationToken cancellationToken)
    {
        await aboutRepository.HardDeleteAsync(
            await aboutRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("About is not found"),
            cancellationToken: cancellationToken);
        return "About is deleted";
    }
}