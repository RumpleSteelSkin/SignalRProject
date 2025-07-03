using FluentValidation;

namespace SRP.Application.Features.Orders.Commands.Add;

public class OrderAddCommandValidator : AbstractValidator<OrderAddCommand>
{
    public OrderAddCommandValidator()
    {
        RuleFor(x => x.TableNumber).NotEmpty().WithMessage("Table is required.");
    }
}