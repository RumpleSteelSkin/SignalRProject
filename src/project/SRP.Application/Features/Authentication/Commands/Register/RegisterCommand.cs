using Core.Application.Pipelines.Transactional;
using MediatR;
using SRP.Application.Services.JwtServices;

namespace SRP.Application.Features.Authentication.Commands.Register;

public class RegisterCommand : IRequest<AccessTokenDto>, ITransactional
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Username { get; set; }
    public string? Mail { get; set; }
    public string? Password { get; set; }
}