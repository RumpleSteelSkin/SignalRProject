using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRP.Domain.Models;

namespace SRP.Persistence.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.Navigation(x => x.Product).AutoInclude();
        builder.Navigation(x => x.MenuTable).AutoInclude();
    }
}