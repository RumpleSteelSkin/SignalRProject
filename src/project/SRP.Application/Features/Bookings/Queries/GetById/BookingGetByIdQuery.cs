using MediatR;

namespace SRP.Application.Features.Bookings.Queries.GetById;

public class BookingGetByIdQuery : IRequest<BookingGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}