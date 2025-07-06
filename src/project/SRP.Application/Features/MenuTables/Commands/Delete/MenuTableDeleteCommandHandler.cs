using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Commands.Delete;

public class MenuTableDeleteCommandHandler(IMenuTableRepository menuTableRepository) : IRequestHandler<MenuTableDeleteCommand, string>
{
    public async Task<string> Handle(MenuTableDeleteCommand request, CancellationToken cancellationToken)
    {
        await menuTableRepository.HardDeleteAsync(
            await menuTableRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("MenuTable is not found"),
            cancellationToken: cancellationToken);
        return "MenuTable is deleted";
    }
}