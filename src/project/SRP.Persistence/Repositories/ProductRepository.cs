using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class ProductRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<Product, int, BaseDbContext>(context), IProductRepository;