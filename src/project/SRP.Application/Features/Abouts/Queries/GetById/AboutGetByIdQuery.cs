using MediatR;

namespace SRP.Application.Features.Abouts.Queries.GetById;

public class AboutGetByIdQuery : IRequest<AboutGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}