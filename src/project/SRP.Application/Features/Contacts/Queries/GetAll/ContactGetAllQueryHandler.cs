using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Queries.GetAll;

public class ContactGetAllQueryHandler(IContactRepository contactRepository, IMapper mapper)
    : IRequestHandler<ContactGetAllQuery, ICollection<ContactGetAllQueryResponseDto>>
{
    public async Task<ICollection<ContactGetAllQueryResponseDto>> Handle(ContactGetAllQuery request,
        CancellationToken cancellationToken)
    {
        return mapper.Map<ICollection<ContactGetAllQueryResponseDto>>(
            await contactRepository.GetAllAsync(enableTracking: false, include: false,
                cancellationToken: cancellationToken));
    }
}