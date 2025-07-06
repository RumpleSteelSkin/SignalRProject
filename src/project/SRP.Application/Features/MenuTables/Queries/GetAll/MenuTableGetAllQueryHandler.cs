using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Queries.GetAll;

public class MenuTableGetAllQueryHandler(IMenuTableRepository menuTableRepository, IMapper mapper)
    : IRequestHandler<MenuTableGetAllQuery, ICollection<MenuTableGetAllQueryResponseDto>>
{
    public async Task<ICollection<MenuTableGetAllQueryResponseDto>> Handle(MenuTableGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<MenuTableGetAllQueryResponseDto>>(
            await menuTableRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}