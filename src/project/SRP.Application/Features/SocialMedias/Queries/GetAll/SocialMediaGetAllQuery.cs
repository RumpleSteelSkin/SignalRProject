using MediatR;

namespace SRP.Application.Features.SocialMedias.Queries.GetAll;

public class SocialMediaGetAllQuery : IRequest<ICollection<SocialMediaGetAllQueryResponseDto>>;