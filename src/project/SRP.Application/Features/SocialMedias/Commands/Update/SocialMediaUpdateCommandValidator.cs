using FluentValidation;

namespace SRP.Application.Features.SocialMedias.Commands.Update;

public class SocialMediaUpdateCommandValidator : AbstractValidator<SocialMediaUpdateCommand>
{
    public SocialMediaUpdateCommandValidator()
    {
        RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Title is required");
    }
}