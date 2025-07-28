using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Messages.Commands.Delete;

public class MessageDeleteCommandHandler(IMessageRepository messageRepository) : IRequestHandler<MessageDeleteCommand, string>
{
    public async Task<string> Handle(MessageDeleteCommand request, CancellationToken cancellationToken)
    {
        await messageRepository.HardDeleteAsync(
            await messageRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("Message is not found"),
            cancellationToken: cancellationToken);
        return "Message is deleted";
    }
}