using MediatR;

namespace SRP.Application.Features.Contacts.Queries.GetAll;

public class ContactGetAllQuery : IRequest<ICollection<ContactGetAllQueryResponseDto>>;