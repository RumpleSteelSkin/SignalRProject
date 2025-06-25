using MediatR;

namespace SRP.Application.Features.Features.Queries.GetAll;

public class FeatureGetAllQuery : IRequest<ICollection<FeatureGetAllQueryResponseDto>>;