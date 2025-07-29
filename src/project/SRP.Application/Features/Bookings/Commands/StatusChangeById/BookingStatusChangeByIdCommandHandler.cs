using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Commands.StatusChangeById;

public class BookingStatusChangeByIdCommandHandler(IBookingRepository bookingRepository)
    : IRequestHandler<BookingStatusChangeByIdCommand, string>
{
    public async Task<string> Handle(BookingStatusChangeByIdCommand request, CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(request.Id, enableTracking: false,
                          include: false, cancellationToken: cancellationToken) ??
                      throw new NotFoundException("Booking not found");
        booking.Description = request.Description;
        await bookingRepository.UpdateAsync(booking, cancellationToken: cancellationToken);
        return $"Booking Status Changed";
    }
}