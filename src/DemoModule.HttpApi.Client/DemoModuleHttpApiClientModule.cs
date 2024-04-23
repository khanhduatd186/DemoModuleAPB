using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DemoModule;

[DependsOn(
    typeof(DemoModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DemoModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DemoModuleApplicationContractsModule).Assembly,
            DemoModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DemoModuleHttpApiClientModule>();
        });

    }
}
