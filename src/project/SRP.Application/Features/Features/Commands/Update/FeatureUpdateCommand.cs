using MediatR;

namespace SRP.Application.Features.Features.Commands.Update;

public class FeatureUpdateCommand : IRequest<string>
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}