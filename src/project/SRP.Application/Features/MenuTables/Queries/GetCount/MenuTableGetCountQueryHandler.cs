using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Queries.GetCount;

public class MenuTableGetCountQueryHandler(IMenuTableRepository menuTableRepository) : IRequestHandler<MenuTableGetCountQuery, int>
{
    public async Task<int> Handle(MenuTableGetCountQuery request, CancellationToken cancellationToken)
    {
        return await menuTableRepository.CountAsync(cancellationToken: cancellationToken);
    }
}