using FluentValidation;

namespace SRP.Application.Features.Discounts.Commands.Update;

public class DiscountUpdateCommandValidator : AbstractValidator<DiscountUpdateCommand>
{
    public DiscountUpdateCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Discount title is required");
    }
}