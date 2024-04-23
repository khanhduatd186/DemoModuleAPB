using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DemoModule.EntityFrameworkCore;

public class DemoModuleHttpApiHostMigrationsDbContext : AbpDbContext<DemoModuleHttpApiHostMigrationsDbContext>
{
    public DemoModuleHttpApiHostMigrationsDbContext(DbContextOptions<DemoModuleHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureDemoModule();
    }
}
