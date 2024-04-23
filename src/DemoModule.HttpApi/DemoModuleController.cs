using DemoModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DemoModule;

public abstract class DemoModuleController : AbpControllerBase
{
    protected DemoModuleController()
    {
        LocalizationResource = typeof(DemoModuleResource);
    }
}
