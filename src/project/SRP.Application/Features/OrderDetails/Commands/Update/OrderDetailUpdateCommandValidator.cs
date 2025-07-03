using FluentValidation;

namespace SRP.Application.Features.OrderDetails.Commands.Update;

public class OrderDetailUpdateCommandValidator : AbstractValidator<OrderDetailUpdateCommand>
{
    public OrderDetailUpdateCommandValidator()
    {
        RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Unit Price is required.");
    }
}