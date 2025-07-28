using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Messages.Queries.GetCount;

public class MessageGetCountQueryHandler(IMessageRepository messageRepository)
    : IRequestHandler<MessageGetCountQuery, int>
{
    public async Task<int> Handle(MessageGetCountQuery request, CancellationToken cancellationToken)
    {
        return await messageRepository.CountAsync(cancellationToken: cancellationToken);
    }
}