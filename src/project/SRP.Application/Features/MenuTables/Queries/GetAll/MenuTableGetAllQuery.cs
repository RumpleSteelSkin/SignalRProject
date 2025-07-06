using MediatR;

namespace SRP.Application.Features.MenuTables.Queries.GetAll;

public class MenuTableGetAllQuery : IRequest<ICollection<MenuTableGetAllQueryResponseDto>>;