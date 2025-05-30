using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class DiscountRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<Discount, int, BaseDbContext>(context), IDiscountRepository;