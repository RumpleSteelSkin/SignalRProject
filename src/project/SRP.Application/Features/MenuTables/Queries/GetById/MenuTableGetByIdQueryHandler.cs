using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.MenuTables.Queries.GetById;

public class MenuTableGetByIdQueryHandler(IMenuTableRepository menuTableRepository, IMapper mapper)
    : IRequestHandler<MenuTableGetByIdQuery, MenuTableGetByIdQueryResponseDto>
{
    public async Task<MenuTableGetByIdQueryResponseDto> Handle(MenuTableGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<MenuTableGetByIdQueryResponseDto>(await menuTableRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}