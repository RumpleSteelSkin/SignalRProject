using MediatR;

namespace SRP.Application.Features.Contacts.Queries.GetById;

public class ContactGetByIdQuery : IRequest<ContactGetByIdQueryResponseDto>
{
    public int Id { get; set; }
}