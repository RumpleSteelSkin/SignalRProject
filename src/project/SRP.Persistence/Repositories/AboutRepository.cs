using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class AboutRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<About, int, BaseDbContext>(context), IAboutRepository;