using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Messages.Commands.Update;

public class MessageUpdateCommandHandler(IMessageRepository messageRepository, IMapper mapper)
    : IRequestHandler<MessageUpdateCommand, string>
{
    public async Task<string> Handle(MessageUpdateCommand request, CancellationToken cancellationToken)
    {
        await messageRepository.UpdateAsync(
            mapper.Map(request,
                await messageRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("Message not updated.")), cancellationToken: cancellationToken);
        return $"Message {request.Subject} is updated.";
    }
}