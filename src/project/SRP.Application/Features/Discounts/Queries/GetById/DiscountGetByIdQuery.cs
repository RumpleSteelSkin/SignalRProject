using MediatR;

namespace SRP.Application.Features.Discounts.Queries.GetById;

public class DiscountGetByIdQuery : IRequest<DiscountGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}