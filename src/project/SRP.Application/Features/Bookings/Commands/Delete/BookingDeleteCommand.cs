using Core.Application.Pipelines.Logging;
using Core.Application.Pipelines.Transactional;
using MediatR;

namespace SRP.Application.Features.Bookings.Commands.Delete;

public class BookingDeleteCommand : IRequest<string>, ITransactional, ILoggableRequest
{
    public required int Id { get; set; }
}