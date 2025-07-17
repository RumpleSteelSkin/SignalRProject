using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Commands.Delete;

public class NotificationDeleteCommandHandler(INotificationRepository notificationRepository) : IRequestHandler<NotificationDeleteCommand, string>
{
    public async Task<string> Handle(NotificationDeleteCommand request, CancellationToken cancellationToken)
    {
        await notificationRepository.HardDeleteAsync(
            await notificationRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, include: false,
                enableTracking: false,
                cancellationToken: cancellationToken) ?? throw new NotFoundException("Notification is not found"),
            cancellationToken: cancellationToken);
        return "Notification is deleted";
    }
}