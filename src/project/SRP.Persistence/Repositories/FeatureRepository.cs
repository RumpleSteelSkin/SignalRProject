using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class FeatureRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<Feature, int, BaseDbContext>(context), IFeatureRepository;