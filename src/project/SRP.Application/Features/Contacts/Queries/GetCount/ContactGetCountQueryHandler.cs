using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Queries.GetCount;

public class ContactGetCountQueryHandler(IContactRepository contactRepository)
    : IRequestHandler<ContactGetCountQuery, int>
{
    public async Task<int> Handle(ContactGetCountQuery request, CancellationToken cancellationToken)
    {
        return await contactRepository.CountAsync(cancellationToken: cancellationToken);
    }
}