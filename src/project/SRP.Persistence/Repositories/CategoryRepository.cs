using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class CategoryRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<Category, int, BaseDbContext>(context), ICategoryRepository;