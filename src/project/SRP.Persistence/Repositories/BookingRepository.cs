using Core.Persistence.Repositories;
using SRP.Application.Services.Repositories;
using SRP.Domain.Models;
using SRP.Persistence.Contexts;

namespace SRP.Persistence.Repositories;

public class BookingRepository(BaseDbContext context)
    : EntityFrameworkRepositoryBase<Booking, int, BaseDbContext>(context), IBookingRepository;