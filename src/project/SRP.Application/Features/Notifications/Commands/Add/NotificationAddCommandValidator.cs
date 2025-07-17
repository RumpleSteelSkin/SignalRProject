using FluentValidation;

namespace SRP.Application.Features.Notifications.Commands.Add;

public class NotificationAddCommandValidator : AbstractValidator<NotificationAddCommand>
{
    public NotificationAddCommandValidator()
    {
        RuleFor(x => x.Type).NotEmpty().WithMessage("Type is required.");
    }
}