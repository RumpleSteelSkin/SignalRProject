using MediatR;

namespace SRP.Application.Features.Bookings.Queries.GetCount;

public class BookingGetCountQuery : IRequest<int>;