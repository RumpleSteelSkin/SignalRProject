using MediatR;

namespace SRP.Application.Features.SocialMedias.Commands.Add;

public class SocialMediaAddCommand : IRequest<string>
{
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Icon { get; set; }
}