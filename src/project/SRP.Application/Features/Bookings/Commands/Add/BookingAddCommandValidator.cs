using FluentValidation;

namespace SRP.Application.Features.Bookings.Commands.Add;

public class BookingAddCommandValidator : AbstractValidator<BookingAddCommand>
{
    public BookingAddCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Booking name is required.");
    }
}