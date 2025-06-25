using FluentValidation;

namespace SRP.Application.Features.Features.Commands.Update;

public class FeatureUpdateCommandValidator : AbstractValidator<FeatureUpdateCommand>
{
    public FeatureUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id cannot be null");
    }
}