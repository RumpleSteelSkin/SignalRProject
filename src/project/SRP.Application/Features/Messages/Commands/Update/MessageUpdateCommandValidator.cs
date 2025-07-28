using FluentValidation;

namespace SRP.Application.Features.Messages.Commands.Update;

public class MessageUpdateCommandValidator : AbstractValidator<MessageUpdateCommand>
{
    public MessageUpdateCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}