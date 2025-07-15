using MediatR;

namespace SRP.Application.Features.Baskets.Queries.GetByMenuTableNumber;

public class BasketGetByMenuTableNumberQuery : IRequest<ICollection<BasketGetByMenuTableNumberQueryResponseDto>>
{
    public int MenuTableID { get; set; }
}