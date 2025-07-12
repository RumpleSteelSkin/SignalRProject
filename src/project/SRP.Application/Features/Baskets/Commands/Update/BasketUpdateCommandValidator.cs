using FluentValidation;

namespace SRP.Application.Features.Baskets.Commands.Update;

public class BasketUpdateCommandValidator : AbstractValidator<BasketUpdateCommand>
{
    public BasketUpdateCommandValidator()
    {
        RuleFor(x => x.Count).NotEmpty().WithMessage("Count is required.");
    }
}