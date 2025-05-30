using Core.Persistence.Repositories;
using SRP.Domain.Models;

namespace SRP.Application.Services.Repositories;

public interface IAboutRepository : IAsyncRepository<About, int>;

public interface IContactRepository : IAsyncRepository<Contact, int>;