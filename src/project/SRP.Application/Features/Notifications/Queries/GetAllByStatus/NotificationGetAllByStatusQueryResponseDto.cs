namespace SRP.Application.Features.Notifications.Queries.GetAllByStatus;

public class NotificationGetAllByStatusQueryResponseDto
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
}