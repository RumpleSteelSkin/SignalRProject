using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Bookings.Commands.Add;

public class BookingAddCommandHandler(IBookingRepository bookingRepository, IMapper mapper)
    : IRequestHandler<BookingAddCommand, string>
{
    public async Task<string> Handle(BookingAddCommand request, CancellationToken cancellationToken)
    {
        await bookingRepository.AddAsync(mapper.Map<Booking>(request), cancellationToken: cancellationToken);
        return $"Booking {request.Name} is added";
    }
}