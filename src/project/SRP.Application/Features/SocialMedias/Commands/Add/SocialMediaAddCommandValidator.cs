using FluentValidation;

namespace SRP.Application.Features.SocialMedias.Commands.Add;

public class SocialMediaAddCommandValidator : AbstractValidator<SocialMediaAddCommand>
{
    public SocialMediaAddCommandValidator()
    {
        RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Title is required");
    }
}