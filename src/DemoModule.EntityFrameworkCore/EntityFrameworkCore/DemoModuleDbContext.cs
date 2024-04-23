using DemoModule.Countries;
using DemoModule.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DemoModule.EntityFrameworkCore;

[ConnectionStringName(DemoModuleDbProperties.ConnectionStringName)]
public class DemoModuleDbContext : AbpDbContext<DemoModuleDbContext>, IDemoModuleDbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Customer> Customers { get; set; }


    public DemoModuleDbContext(DbContextOptions<DemoModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDemoModule();
    }
}
