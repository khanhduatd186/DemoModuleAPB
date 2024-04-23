using DemoModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DemoModule.Permissions;

public class DemoModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DemoModulePermissions.GroupName, L("Permission:DemoModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DemoModuleResource>(name);
    }
}
