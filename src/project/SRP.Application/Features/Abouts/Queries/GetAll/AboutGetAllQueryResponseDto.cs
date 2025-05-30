namespace SRP.Application.Features.Abouts.Queries.GetAll;

public class AboutGetAllQueryResponseDto
{
    public int Id { get; set; }
    public string? ImageUrl { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}