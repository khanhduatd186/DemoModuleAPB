using Volo.Abp.Modularity;

namespace DemoModule;

[DependsOn(
    typeof(DemoModuleApplicationModule),
    typeof(DemoModuleDomainTestModule)
    )]
public class DemoModuleApplicationTestModule : AbpModule
{

}
