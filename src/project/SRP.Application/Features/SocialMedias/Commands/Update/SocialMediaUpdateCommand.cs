using MediatR;

namespace SRP.Application.Features.SocialMedias.Commands.Update;

public class SocialMediaUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Icon { get; set; }
}