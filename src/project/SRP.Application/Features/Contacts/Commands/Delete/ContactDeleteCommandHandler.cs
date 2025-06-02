using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Commands.Delete;

public class ContactDeleteCommandHandler(IContactRepository contactRepository)
    : IRequestHandler<ContactDeleteCommand, string>
{
    public async Task<string> Handle(ContactDeleteCommand request, CancellationToken cancellationToken)
    {
        await contactRepository.HardDeleteAsync(
            await contactRepository.GetByIdAsync(id: request.Id, ignoreQueryFilters: true, enableTracking: false,
                include: false, cancellationToken: cancellationToken) ??
            throw new NotFoundException("Contact not found."), cancellationToken: cancellationToken);
        return "Contact is deleted.";
    }
}