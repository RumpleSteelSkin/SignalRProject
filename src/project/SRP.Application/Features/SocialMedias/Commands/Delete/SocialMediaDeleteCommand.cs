using MediatR;

namespace SRP.Application.Features.SocialMedias.Commands.Delete;

public class SocialMediaDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}