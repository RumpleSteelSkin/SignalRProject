using MediatR;

namespace SRP.Application.Features.Discounts.Queries.GetAllByStatus;

public class DiscountGetAllByStatusQuery : IRequest<ICollection<DiscountGetAllByStatusQueryResponseDto>>
{
    public bool Status { get; set; }
}