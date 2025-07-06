using MediatR;

namespace SRP.Application.Features.MoneyCases.Queries.GetById;

public class MoneyCaseGetByIdQuery : IRequest<MoneyCaseGetByIdQueryResponseDto>
{
    public required int Id { get; set; }
}