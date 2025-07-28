using MediatR;

namespace SRP.Application.Features.Messages.Queries.GetCount;

public class MessageGetCountQuery : IRequest<int>;