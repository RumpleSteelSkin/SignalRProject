namespace SRP.Application.Features.Authentication.Queries.GetUsersByRoleId;

public class GetUsersByRoleIdQueryResponseDto
{
    public string? UserName { get; set; }
    public string? FullName { get; set; }
    public string? Mail { get; set; }
}