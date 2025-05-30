using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Abouts.Commands.Update;

public class AboutUpdateCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
    : IRequestHandler<AboutUpdateCommand, string>
{
    public async Task<string> Handle(AboutUpdateCommand request, CancellationToken cancellationToken)
    {
        await aboutRepository.UpdateAsync(
            mapper.Map(request,
                await aboutRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("About not updated.")), cancellationToken: cancellationToken);
        return $"About {request.Title} is updated.";
    }
}