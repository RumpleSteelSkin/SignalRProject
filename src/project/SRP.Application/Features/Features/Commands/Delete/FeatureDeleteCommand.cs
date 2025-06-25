using MediatR;

namespace SRP.Application.Features.Features.Commands.Delete;

public class FeatureDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}