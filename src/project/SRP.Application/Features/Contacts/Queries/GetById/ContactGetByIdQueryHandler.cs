using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Queries.GetById;

public class ContactGetByIdQueryHandler(IContactRepository contactRepository, IMapper mapper)
    : IRequestHandler<ContactGetByIdQuery, ContactGetByIdQueryResponseDto>
{
    public async Task<ContactGetByIdQueryResponseDto> Handle(ContactGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ContactGetByIdQueryResponseDto>(await contactRepository.GetByIdAsync(id: request.Id,
            ignoreQueryFilters: true, enableTracking: false, include: false, cancellationToken: cancellationToken));
    }
}