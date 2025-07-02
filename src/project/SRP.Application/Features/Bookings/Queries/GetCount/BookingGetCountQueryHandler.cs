using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Queries.GetCount;

public class BookingGetCountQueryHandler(IBookingRepository bookingRepository) : IRequestHandler<BookingGetCountQuery, int>
{
    public async Task<int> Handle(BookingGetCountQuery request, CancellationToken cancellationToken)
    {
        return await bookingRepository.CountAsync(cancellationToken: cancellationToken);
    }
}