using AutoMapper;
using FluentValidation;
using MediatR;
using SRP.Application.Services.Repositories;

namespace SRP.Application.Features.Contacts.Commands.Add;

public class ContactAddCommand : IRequest<string>
{
}

public class ContactAddCommandHandler(IContactRepository contactRepository, IMapper mapper)
    : IRequestHandler<ContactAddCommand, string>
{
    public Task<string> Handle(ContactAddCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public class ContactAddCommandValidator : AbstractValidator<ContactAddCommand>
{
}