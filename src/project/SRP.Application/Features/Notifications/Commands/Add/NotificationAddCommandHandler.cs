using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Notifications.Commands.Add;

public class NotificationAddCommandHandler(INotificationRepository notificationRepository, IMapper mapper)
    : IRequestHandler<NotificationAddCommand, string>
{
    public async Task<string> Handle(NotificationAddCommand request, CancellationToken cancellationToken)
    {
        await notificationRepository.AddAsync(mapper.Map<Notification>(request), cancellationToken);
        return $"Notification {request.Description} has been successfully added.";
    }
}