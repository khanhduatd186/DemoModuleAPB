using Volo.Abp.Bundling;

namespace DemoModule.Blazor.Host;

public class DemoModuleBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
