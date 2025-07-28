using MediatR;

namespace SRP.Application.Features.Authentication.Queries.GetUserDetailById;

public class GetUserDetailByIdQuery : IRequest<GetUserDetailByIdQueryResponseDto>
{
    public int? UserId { get; set; }
}