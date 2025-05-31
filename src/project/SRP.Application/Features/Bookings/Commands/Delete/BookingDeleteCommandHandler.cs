using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Commands.Delete;

public class BookingDeleteCommandHandler(IBookingRepository bookingRepository, IMapper mapper)
    : IRequestHandler<BookingDeleteCommand, string>
{
    public async Task<string> Handle(BookingDeleteCommand request, CancellationToken cancellationToken)
    {
        await bookingRepository.HardDeleteAsync(
            await bookingRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Booking not found."), cancellationToken: cancellationToken);
        return "Booking is deleted.";
    }
}