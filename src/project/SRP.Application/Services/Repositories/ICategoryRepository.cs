using Core.Persistence.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Services.Repositories;

public interface ICategoryRepository : IAsyncRepository<Category, int>;