using MediatR;

namespace SRP.Application.Features.Contacts.Commands.Delete;

public class ContactDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}