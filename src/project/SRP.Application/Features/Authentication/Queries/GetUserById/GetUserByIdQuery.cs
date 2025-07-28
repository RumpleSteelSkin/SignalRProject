using MediatR;

namespace SRP.Application.Features.Authentication.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<GetUserByIdQueryResponseDto>
{
    public int? UserId { get; set; }
}