using MediatR;

namespace SRP.Application.Features.Messages.Queries.GetById;

public class MessageGetByIdQuery : IRequest<MessageGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}