using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Commands.Update;

public class BookingUpdateCommandHandler(IBookingRepository bookingRepository, IMapper mapper)
    : IRequestHandler<BookingUpdateCommand, string>
{
    public async Task<string> Handle(BookingUpdateCommand request, CancellationToken cancellationToken)
    {
        await bookingRepository.UpdateAsync(
            mapper.Map(request,
                await bookingRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Booking is not found")),
            cancellationToken: cancellationToken);
        return $"Booking {request.Name} is updated.";
    }
}