using MediatR;

namespace SRP.Application.Features.Bookings.Queries.GetAll;

public class BookingGetAllQuery : IRequest<ICollection<BookingGetAllQueryResponseDto>>;