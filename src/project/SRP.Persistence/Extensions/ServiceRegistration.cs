using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SRP.Application.Services.Repositories;
using SRP.Persistence.Contexts;
using SRP.Persistence.Repositories;

namespace SRP.Persistence.Extensions;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        #region Entity Framework Services

        services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString(configuration.GetSection("ConnectionStringsSelector")
                    .Get<string>()!)));

        #endregion

        #region Repository Interface Define

        services.AddScoped<IAboutRepository, AboutRepository>();
        services.AddScoped<IBookingRepository, BookingRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IDiscountRepository, DiscountRepository>();
        services.AddScoped<IFeatureRepository, FeatureRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
        services.AddScoped<ITestimonialRepository, TestimonialRepository>();
        services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IMoneyCaseRepository, MoneyCaseRepository>();
        services.AddScoped<IMenuTableRepository, MenuTableRepository>();
        services.AddScoped<IBasketRepository, BasketRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();

        #endregion

        return services;
    }
}