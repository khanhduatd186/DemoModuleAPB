using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
namespace DemoModule.EntityFrameworkCore;

public class DemoModuleHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DemoModuleHttpApiHostMigrationsDbContext>
{
    public DemoModuleHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DemoModuleHttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("DemoModule"));

        return new DemoModuleHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
