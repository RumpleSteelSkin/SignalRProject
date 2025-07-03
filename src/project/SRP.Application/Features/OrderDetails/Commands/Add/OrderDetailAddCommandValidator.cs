using FluentValidation;

namespace SRP.Application.Features.OrderDetails.Commands.Add;

public class OrderDetailAddCommandValidator : AbstractValidator<OrderDetailAddCommand>
{
    public OrderDetailAddCommandValidator()
    {
        RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Unit Price is required.");
    }
}