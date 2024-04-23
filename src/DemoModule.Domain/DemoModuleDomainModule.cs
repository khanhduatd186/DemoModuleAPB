using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace DemoModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DemoModuleDomainSharedModule)
)]
public class DemoModuleDomainModule : AbpModule
{

}
