using FluentValidation;

namespace SRP.Application.Features.Features.Commands.Add;

public class FeatureAddCommandValidator : AbstractValidator<FeatureAddCommand>
{
    public FeatureAddCommandValidator()
    {
        RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Title is required.");
    }
}