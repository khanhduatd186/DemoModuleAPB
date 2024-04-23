using Volo.Abp.Modularity;

namespace DemoModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class DemoModuleApplicationTestBase<TStartupModule> : DemoModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
