using MediatR;

namespace SRP.Application.Features.Baskets.Queries.GetAll;

public class BasketGetAllQuery : IRequest<ICollection<BasketGetAllQueryResponseDto>>;