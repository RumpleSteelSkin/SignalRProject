using MediatR;

namespace SRP.Application.Features.SocialMedias.Queries.GetById;

public class SocialMediaGetByIdQuery : IRequest<SocialMediaGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}