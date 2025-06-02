using FluentValidation;

namespace SRP.Application.Features.Discounts.Commands.Add;

public class DiscountAddCommandValidator : AbstractValidator<DiscountAddCommand>
{
    public DiscountAddCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Discount title is required");
    }
}