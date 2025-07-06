using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.MenuTables.Commands.Add;

public class MenuTableAddCommandHandler(IMenuTableRepository menuTableRepository, IMapper mapper)
    : IRequestHandler<MenuTableAddCommand, string>
{
    public async Task<string> Handle(MenuTableAddCommand request, CancellationToken cancellationToken)
    {
        await menuTableRepository.AddAsync(mapper.Map<MenuTable>(request), cancellationToken);
        return $"MenuTable {request.Name} has been successfully added.";
    }
}