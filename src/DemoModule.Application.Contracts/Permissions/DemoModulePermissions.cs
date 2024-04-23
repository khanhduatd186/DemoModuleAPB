using Volo.Abp.Reflection;

namespace DemoModule.Permissions;

public class DemoModulePermissions
{
    public const string GroupName = "DemoModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DemoModulePermissions));
    }
}
