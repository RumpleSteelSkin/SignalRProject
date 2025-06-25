using MediatR;

namespace SRP.Application.Features.Features.Queries.GetById;

public class FeatureGetByIdQuery : IRequest<FeatureGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}