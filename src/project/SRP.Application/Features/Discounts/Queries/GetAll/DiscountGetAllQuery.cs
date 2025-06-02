using MediatR;

namespace SRP.Application.Features.Discounts.Queries.GetAll;

public class DiscountGetAllQuery : IRequest<ICollection<DiscountGetAllQueryResponseDto>>;