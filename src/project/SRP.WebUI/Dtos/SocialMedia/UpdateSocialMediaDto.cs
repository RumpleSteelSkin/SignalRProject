﻿namespace SRP.WebUI.Dtos.SocialMedia;

public class UpdateSocialMediaDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Icon { get; set; }
}