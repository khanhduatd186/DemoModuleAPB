using Volo.Abp.Modularity;

namespace DemoModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class DemoModuleDomainTestBase<TStartupModule> : DemoModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
