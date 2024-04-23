using DemoModule.Localization;
using Volo.Abp.Application.Services;

namespace DemoModule;

public abstract class DemoModuleAppService : ApplicationService
{
    protected DemoModuleAppService()
    {
        LocalizationResource = typeof(DemoModuleResource);
        ObjectMapperContext = typeof(DemoModuleApplicationModule);
    }
}
