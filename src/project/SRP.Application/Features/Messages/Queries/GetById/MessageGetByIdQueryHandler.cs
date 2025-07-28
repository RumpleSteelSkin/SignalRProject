using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Messages.Queries.GetById;

public class MessageGetByIdQueryHandler(IMessageRepository messageRepository, IMapper mapper)
    : IRequestHandler<MessageGetByIdQuery, MessageGetByIdQueryResponseDto>
{
    public async Task<MessageGetByIdQueryResponseDto> Handle(MessageGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<MessageGetByIdQueryResponseDto>(await messageRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}