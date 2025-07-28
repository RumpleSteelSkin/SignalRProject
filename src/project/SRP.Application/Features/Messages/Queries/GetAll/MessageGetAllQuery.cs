using MediatR;

namespace SRP.Application.Features.Messages.Queries.GetAll;

public class MessageGetAllQuery : IRequest<ICollection<MessageGetAllQueryResponseDto>>;