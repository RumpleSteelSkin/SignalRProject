using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Testimonials.Commands.Update;

public class TestimonialUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}