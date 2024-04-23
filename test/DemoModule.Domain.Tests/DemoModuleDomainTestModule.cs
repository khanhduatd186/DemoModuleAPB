using Volo.Abp.Modularity;

namespace DemoModule;

[DependsOn(
    typeof(DemoModuleDomainModule),
    typeof(DemoModuleTestBaseModule)
)]
public class DemoModuleDomainTestModule : AbpModule
{

}
