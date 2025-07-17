using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Commands.UpdateStatusById;

public class NotificationUpdateStatusByIdCommandHandler(INotificationRepository notificationRepository)
    : IRequestHandler<NotificationUpdateStatusByIdCommand, string>
{
    public async Task<string> Handle(NotificationUpdateStatusByIdCommand request, CancellationToken cancellationToken)
    {
        var notification =
            await notificationRepository.GetByIdAsync(request.Id, enableTracking: false, include: false,
                cancellationToken: cancellationToken) ?? throw new BusinessException("Notification not updated.");
        notification.Status = request.Status;
        await notificationRepository.UpdateAsync(notification, cancellationToken);
        return "Notification updated";
    }
}