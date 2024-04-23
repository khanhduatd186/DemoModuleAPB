using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DemoModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DemoModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class DemoModuleConsoleApiClientModule : AbpModule
{

}
