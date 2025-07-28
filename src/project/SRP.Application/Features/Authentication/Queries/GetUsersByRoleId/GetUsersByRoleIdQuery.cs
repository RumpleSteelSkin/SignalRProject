using MediatR;

namespace SRP.Application.Features.Authentication.Queries.GetUsersByRoleId;

public class GetUsersByRoleIdQuery : IRequest<ICollection<GetUsersByRoleIdQueryResponseDto>>
{
    public int? RoleId { get; set; }
}