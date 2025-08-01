﻿namespace SRP.WebUI.Dtos.Contact;

public class CreateContactDto
{
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterDescription { get; set; }
    public string? OpenDays { get; set; }
    public string? OpenDaysDescription { get; set; }
    public string? OpenHours { get; set; }
}