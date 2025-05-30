using MediatR;

namespace SRP.Application.Features.Abouts.Queries.GetAll;

public class AboutGetAllQuery : IRequest<ICollection<AboutGetAllQueryResponseDto>>;