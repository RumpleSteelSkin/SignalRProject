using FluentValidation;

namespace SRP.Application.Features.Orders.Commands.Update;

public class OrderUpdateCommandValidator : AbstractValidator<OrderUpdateCommand>
{
    public OrderUpdateCommandValidator()
    {
        RuleFor(x => x.TableNumber).NotEmpty().WithMessage("Table is required.");
    }
}