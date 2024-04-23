using DemoModule.Countries;
using DemoModule.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DemoModule.EntityFrameworkCore;

public static class DemoModuleDbContextModelCreatingExtensions
{
    public static void ConfigureDemoModule(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
        builder.Entity<Country>(b =>
        {
            b.ToTable(DemoModuleDbProperties.DbTablePrefix + "Countries", DemoModuleDbProperties.DbSchema);

            b.ConfigureByConvention();
        });

        builder.Entity<Customer>(b =>
        {
            b.ToTable(DemoModuleDbProperties.DbTablePrefix + "Customers", DemoModuleDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.HasOne<Country>()
                .WithMany()
                .HasForeignKey(p => p.CountryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
