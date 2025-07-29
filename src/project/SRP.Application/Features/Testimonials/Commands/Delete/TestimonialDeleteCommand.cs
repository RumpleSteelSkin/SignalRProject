using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Testimonials.Commands.Delete;

public class TestimonialDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public int Id { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}