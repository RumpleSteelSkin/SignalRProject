namespace SRP.Application.Features.Authentication.Queries.GetUserDetailById;

public class GetUserDetailByIdQueryResponseDto
{
    public string? UserName { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Mail { get; set; }
}