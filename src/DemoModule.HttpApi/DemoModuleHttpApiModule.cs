using Localization.Resources.AbpUi;
using DemoModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace DemoModule;

[DependsOn(
    typeof(DemoModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class DemoModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DemoModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DemoModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
