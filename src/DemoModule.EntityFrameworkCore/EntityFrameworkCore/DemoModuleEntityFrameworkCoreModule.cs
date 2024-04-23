using DemoModule.Countries;
using DemoModule.Customers;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DemoModule.EntityFrameworkCore;

[DependsOn(
    typeof(DemoModuleDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class DemoModuleEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<DemoModuleDbContext>(options =>
        {
            options.AddRepository<Country, EfCoreRepository<IDemoModuleDbContext, Country, Guid>>();
            options.AddRepository<Customer, EfCoreRepository<IDemoModuleDbContext, Customer, Guid>>();
        });
    }
}
