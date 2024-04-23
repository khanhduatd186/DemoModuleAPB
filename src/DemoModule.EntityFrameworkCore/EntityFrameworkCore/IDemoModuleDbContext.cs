using DemoModule.Countries;
using DemoModule.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DemoModule.EntityFrameworkCore;

[ConnectionStringName(DemoModuleDbProperties.ConnectionStringName)]
public interface IDemoModuleDbContext : IEfCoreDbContext
{
    DbSet<Country> Countries { get; }
    DbSet<Customer> Customers { get; }
}
