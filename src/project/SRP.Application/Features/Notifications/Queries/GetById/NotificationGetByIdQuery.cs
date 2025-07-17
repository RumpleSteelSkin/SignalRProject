using MediatR;

namespace SRP.Application.Features.Notifications.Queries.GetById;

public class NotificationGetByIdQuery : IRequest<NotificationGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}