using AutoMapper;
using MediatR;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Features.Contacts.Commands.Add;

public class ContactAddCommandHandler(IContactRepository contactRepository, IMapper mapper)
    : IRequestHandler<ContactAddCommand, string>
{
    public async Task<string> Handle(ContactAddCommand request, CancellationToken cancellationToken)
    {
        await contactRepository.AddAsync(mapper.Map<Contact>(request), cancellationToken: cancellationToken);
        return $"Contact {request.FooterTitle} is added.";
    }
}