using FluentValidation;

namespace SRP.Application.Features.MoneyCases.Commands.Add;

public class MoneyCaseAddCommandValidator : AbstractValidator<MoneyCaseAddCommand>
{
    public MoneyCaseAddCommandValidator()
    {
        RuleFor(x => x.TotalAmount).NotEmpty().WithMessage("Title is required.");
    }
}