using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Commands.UpdateState;

public class MenuTableUpdateStateCommandHandler(IMenuTableRepository menuTableRepository, IMapper mapper)
    : IRequestHandler<MenuTableUpdateStateCommand, string>
{
    public async Task<string> Handle(MenuTableUpdateStateCommand request, CancellationToken cancellationToken)
    {
        await menuTableRepository.UpdateAsync(
            mapper.Map(request,
                await menuTableRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("MenuTable not updated.")), cancellationToken: cancellationToken);
        return "MenuTable is updated.";
    }
}