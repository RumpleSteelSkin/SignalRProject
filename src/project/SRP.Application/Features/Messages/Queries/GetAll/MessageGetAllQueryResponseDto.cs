namespace SRP.Application.Features.Messages.Queries.GetAll;

public class MessageGetAllQueryResponseDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }
    public string? Subject { get; set; }
    public string? MessageContent { get; set; }
}