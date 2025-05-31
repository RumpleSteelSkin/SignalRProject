using FluentValidation;

namespace SRP.Application.Features.Bookings.Commands.Update;

public class BookingUpdateCommandValidator : AbstractValidator<BookingUpdateCommand>
{
    public BookingUpdateCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Booking name is required.");
    }
}