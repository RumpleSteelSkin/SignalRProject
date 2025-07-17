namespace SRP.Application.Features.Notifications.Queries.GetById;

public class NotificationGetByIdQueryResponseDto
{
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
}