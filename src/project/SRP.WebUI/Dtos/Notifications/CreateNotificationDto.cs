﻿namespace SRP.WebUI.Dtos.Notifications;

public class CreateNotificationDto
{
    public string? Type { get; set; }
    public string? Icon { get; set; }
    public string? Description { get; set; }
}