using FluentValidation;

namespace SRP.Application.Features.Abouts.Commands.Update;

public class AboutUpdateCommandValidator : AbstractValidator<AboutUpdateCommand>
{
    public AboutUpdateCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
    }
}