namespace SRP.WebUI.Dtos.Identity;

public class LoginResponseDto
{
    public string? Token { get; set; }
    public DateTime TokenExpiration { get; set; }
    public string? Issuer { get; set; }
    public List<string>? Audience { get; set; }
    public int AccessTokenExpiration { get; set; }
    public string? SecurityKey { get; set; }
}