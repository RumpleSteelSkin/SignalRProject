namespace SRP.Application.Features.Messages.Queries.GetById;

public class MessageGetByIdQueryResponseDto
{
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }
    public string? Subject { get; set; }
    public string? MessageContent { get; set; }
}