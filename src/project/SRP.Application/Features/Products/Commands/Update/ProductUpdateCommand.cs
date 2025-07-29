using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.Products.Commands.Update;

public class ProductUpdateCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
    public int CategoryID { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}