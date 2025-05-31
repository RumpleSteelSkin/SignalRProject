using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Queries.GetAll;

public class BookingGetAllQueryHandler(IBookingRepository bookingRepository, IMapper mapper)
    : IRequestHandler<BookingGetAllQuery, ICollection<BookingGetAllQueryResponseDto>>
{
    public async Task<ICollection<BookingGetAllQueryResponseDto>> Handle(BookingGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<BookingGetAllQueryResponseDto>>(
            await bookingRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}