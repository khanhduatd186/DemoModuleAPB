using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace DemoModule.Blazor.WebAssembly;

[DependsOn(
    typeof(DemoModuleBlazorModule),
    typeof(DemoModuleHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class DemoModuleBlazorWebAssemblyModule : AbpModule
{

}
