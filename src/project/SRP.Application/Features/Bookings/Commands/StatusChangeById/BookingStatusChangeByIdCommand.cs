using MediatR;

namespace SRP.Application.Features.Bookings.Commands.StatusChangeById;

public class BookingStatusChangeByIdCommand : IRequest<string>
{
    public required int Id { get; set; }
    public string? Description { get; set; }
}