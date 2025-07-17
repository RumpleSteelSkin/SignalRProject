using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Commands.Update;

public class NotificationUpdateCommandHandler(INotificationRepository notificationRepository, IMapper mapper)
    : IRequestHandler<NotificationUpdateCommand, string>
{
    public async Task<string> Handle(NotificationUpdateCommand request, CancellationToken cancellationToken)
    {
        await notificationRepository.UpdateAsync(
            mapper.Map(request,
                await notificationRepository.GetByIdAsync(request.Id, ignoreQueryFilters: true, enableTracking: false,
                    include: false, cancellationToken: cancellationToken) ??
                throw new BusinessException("Notification not updated.")), cancellationToken: cancellationToken);
        return $"Notification {request.Description} is updated.";
    }
}