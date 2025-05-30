using MediatR;

namespace SRP.Application.Features.Abouts.Commands.Delete;

public class AboutDeleteCommand : IRequest<string>
{
    public required int Id { get; set; }
}