namespace SRP.WebUI.Dtos.Validation;

public class FluentValidationErrorResponse
{
    public string? Type { get; set; }
    public string? Title { get; set; }
    public int Status { get; set; }
    public List<ValidationError>? Errors { get; set; }
}