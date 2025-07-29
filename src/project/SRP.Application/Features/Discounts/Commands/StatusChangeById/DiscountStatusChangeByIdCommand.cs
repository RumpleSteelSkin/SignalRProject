using MediatR;

namespace SRP.Application.Features.Discounts.Commands.StatusChangeById;

public class DiscountStatusChangeByIdCommand : IRequest<string>
{
    public int Id { get; set; }
    public bool Status { get; set; }
}