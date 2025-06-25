using MediatR;

namespace SRP.Application.Features.Products.Commands.Delete;

public class ProductDeleteCommand : IRequest<string>
{
    public int Id { get; set; }
}