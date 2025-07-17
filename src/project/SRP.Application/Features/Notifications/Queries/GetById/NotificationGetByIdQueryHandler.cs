using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Notifications.Queries.GetById;

public class NotificationGetByIdQueryHandler(INotificationRepository notificationRepository, IMapper mapper)
    : IRequestHandler<NotificationGetByIdQuery, NotificationGetByIdQueryResponseDto>
{
    public async Task<NotificationGetByIdQueryResponseDto> Handle(NotificationGetByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<NotificationGetByIdQueryResponseDto>(await notificationRepository.GetByIdAsync(id: request.Id,
            enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}