using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Messages.Commands.Add;

public class MessageAddCommandHandler(IMessageRepository messageRepository, IMapper mapper)
    : IRequestHandler<MessageAddCommand, string>
{
    public async Task<string> Handle(MessageAddCommand request, CancellationToken cancellationToken)
    {
        await messageRepository.AddAsync(mapper.Map<Message>(request), cancellationToken);
        return $"Message {request.Name} has been successfully added.";
    }
}