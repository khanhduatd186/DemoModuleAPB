using Microsoft.Extensions.DependencyInjection;
using DemoModule.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace DemoModule.Blazor;

[DependsOn(
    typeof(DemoModuleApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class DemoModuleBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<DemoModuleBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<DemoModuleBlazorAutoMapperProfile>(validate: false);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new DemoModuleMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(DemoModuleBlazorModule).Assembly);
        });
    }
}
