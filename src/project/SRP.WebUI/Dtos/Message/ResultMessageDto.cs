namespace SRP.WebUI.Dtos.Message;

public class ResultMessageDto
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }
    public string? Subject { get; set; }
    public string? MessageContent { get; set; }
}