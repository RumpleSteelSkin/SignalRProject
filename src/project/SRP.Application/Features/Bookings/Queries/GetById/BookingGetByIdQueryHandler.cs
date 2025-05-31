using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Bookings.Queries.GetById;

public class BookingGetByIdQueryHandler(IBookingRepository bookingRepository, IMapper mapper)
    : IRequestHandler<BookingGetByIdQuery, BookingGetByIdQueryResponseDto>
{
    public async Task<BookingGetByIdQueryResponseDto> Handle(BookingGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<BookingGetByIdQueryResponseDto>(await bookingRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}