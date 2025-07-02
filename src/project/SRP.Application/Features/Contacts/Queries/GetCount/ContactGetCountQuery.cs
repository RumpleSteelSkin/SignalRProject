using MediatR;

namespace SRP.Application.Features.Contacts.Queries.GetCount;

public class ContactGetCountQuery : IRequest<int>;