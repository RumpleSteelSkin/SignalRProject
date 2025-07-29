using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Constants;

namespace SRP.Application.Features.MoneyCases.Commands.Add;

public class MoneyCaseAddCommand : IRequest<string>, ITransactional, ILoggableRequest, IRoleExists
{
    public decimal TotalAmount { get; set; }
    public string[] Roles => [GeneralOperationClaims.Admin];
}