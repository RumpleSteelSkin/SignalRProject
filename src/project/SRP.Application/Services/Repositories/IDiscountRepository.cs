using Core.Persistence.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Services.Repositories;

public interface IDiscountRepository : IAsyncRepository<Discount, int>;