using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Commands.Update;

public class ContactUpdateCommandHandler(IContactRepository contactRepository, IMapper mapper)
    : IRequestHandler<ContactUpdateCommand, string>
{
    public async Task<string> Handle(ContactUpdateCommand request, CancellationToken cancellationToken)
    {
        await contactRepository.UpdateAsync(
            mapper.Map(request,
                await contactRepository.GetByIdAsync(id: request.Id, enableTracking: false, include: false,
                    cancellationToken: cancellationToken) ?? throw new NotFoundException("Contact is not found")),
            cancellationToken: cancellationToken);
        return $"Contact {request.FooterTitle} is updated.";
    }
}