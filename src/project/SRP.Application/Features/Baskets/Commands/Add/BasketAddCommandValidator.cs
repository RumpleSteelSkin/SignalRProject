using FluentValidation;

namespace SRP.Application.Features.Baskets.Commands.Add;

public class BasketAddCommandValidator : AbstractValidator<BasketAddCommand>
{
    public BasketAddCommandValidator()
    {
        RuleFor(x => x.Count).NotEmpty().WithMessage("Count is required.");
    }
}