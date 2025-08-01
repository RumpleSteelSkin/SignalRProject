﻿namespace SRP.WebUI.Dtos.Identity;

public class UserEditDto
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Username { get; set; }
    public string? Mail { get; set; }
    public string? Password { get; set; }
}