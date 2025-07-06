using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Commands.Update;

public class MenuTableUpdateCommandHandler(IMenuTableRepository menuTableRepository, IMapper mapper)
    : IRequestHandler<MenuTableUpdateCommand, string>
{
    public async Task<string> Handle(MenuTableUpdateCommand request, CancellationToken cancellationToken)
    {
        await menuTableRepository.UpdateAsync(
            mapper.Map(request,
                await menuTableRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("MenuTable not updated.")), cancellationToken: cancellationToken);
        return $"MenuTable {request.Name} is updated.";
    }
}