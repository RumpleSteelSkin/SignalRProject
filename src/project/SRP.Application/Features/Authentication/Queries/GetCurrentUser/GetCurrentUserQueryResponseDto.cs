﻿namespace SRP.Application.Features.Authentication.Queries.GetCurrentUser;

public class GetCurrentUserQueryResponseDto
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Username { get; set; }
    public string? Mail { get; set; }
}