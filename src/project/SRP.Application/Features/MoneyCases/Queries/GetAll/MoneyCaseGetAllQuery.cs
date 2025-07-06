using MediatR;

namespace SRP.Application.Features.MoneyCases.Queries.GetAll;

public class MoneyCaseGetAllQuery : IRequest<ICollection<MoneyCaseGetAllQueryResponseDto>>;