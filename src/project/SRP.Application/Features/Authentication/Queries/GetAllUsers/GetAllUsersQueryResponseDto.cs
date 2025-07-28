namespace SRP.Application.Features.Authentication.Queries.GetAllUsers;

public class GetAllUsersQueryResponseDto
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? FullName { get; set; }
    public string? Mail { get; set; }
}