using FluentValidation;

namespace SRP.Application.Features.Abouts.Commands.Add;

public class AboutAddCommandValidator : AbstractValidator<AboutAddCommand>
{
    public AboutAddCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
    }
}