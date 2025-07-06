using FluentValidation;

namespace SRP.Application.Features.MoneyCases.Commands.Update;

public class MoneyCaseUpdateCommandValidator : AbstractValidator<MoneyCaseUpdateCommand>
{
    public MoneyCaseUpdateCommandValidator()
    {
        RuleFor(x => x.TotalAmount).NotEmpty().WithMessage("Title is required.");
    }
}