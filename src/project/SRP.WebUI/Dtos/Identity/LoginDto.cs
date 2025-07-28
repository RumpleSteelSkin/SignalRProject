namespace SRP.WebUI.Dtos.Identity;

public class LoginDto
{
    public string? UserNameOrEmail { get; set; }
    public string? Password { get; set; }
}