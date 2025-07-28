using MediatR;

namespace SRP.Application.Features.Authentication.Queries.GetAllUsers;

public class GetAllUsersQuery : IRequest<ICollection<GetAllUsersQueryResponseDto>>;