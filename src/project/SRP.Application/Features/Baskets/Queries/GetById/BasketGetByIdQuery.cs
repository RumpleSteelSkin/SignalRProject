using MediatR;

namespace SRP.Application.Features.Baskets.Queries.GetById;

public class BasketGetByIdQuery : IRequest<BasketGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}