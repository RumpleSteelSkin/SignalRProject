using MediatR;

namespace SRP.Application.Features.MenuTables.Queries.GetById;

public class MenuTableGetByIdQuery : IRequest<MenuTableGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}