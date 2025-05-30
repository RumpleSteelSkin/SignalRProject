using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class SocialMediaRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<SocialMedia, int, BaseDbContext>(context), ISocialMediaRepository;