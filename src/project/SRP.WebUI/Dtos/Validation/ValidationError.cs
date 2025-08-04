namespace SRP.WebUI.Dtos.Validation;

public class ValidationError
{
    public string? Property { get; set; }
    public ICollection<string>? Errors { get; set; }
}