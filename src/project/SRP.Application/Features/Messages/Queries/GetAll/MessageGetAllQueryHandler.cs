using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Messages.Queries.GetAll;

public class MessageGetAllQueryHandler(IMessageRepository messageRepository, IMapper mapper)
    : IRequestHandler<MessageGetAllQuery, ICollection<MessageGetAllQueryResponseDto>>
{
    public async Task<ICollection<MessageGetAllQueryResponseDto>> Handle(MessageGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<MessageGetAllQueryResponseDto>>(
            await messageRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}