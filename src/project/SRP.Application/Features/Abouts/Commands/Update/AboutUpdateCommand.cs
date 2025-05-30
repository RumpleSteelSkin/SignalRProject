using MediatR;

namespace SRP.Application.Features.Abouts.Commands.Update;

public class AboutUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? ImageUrl { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}