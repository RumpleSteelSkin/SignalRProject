using MediatR;

namespace SRP.Application.Features.Features.Commands.Add;

public class FeatureAddCommand : IRequest<string>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
}