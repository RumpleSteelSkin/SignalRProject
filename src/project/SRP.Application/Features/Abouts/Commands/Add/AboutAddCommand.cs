using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Abouts.Commands.Add;

public class AboutAddCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public string? ImageUrl { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}