using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace DemoModule;

[DependsOn(
    typeof(DemoModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class DemoModuleApplicationContractsModule : AbpModule
{

}
