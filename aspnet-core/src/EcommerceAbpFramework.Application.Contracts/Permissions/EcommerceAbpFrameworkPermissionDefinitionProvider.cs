using EcommerceAbpFramework.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EcommerceAbpFramework.Permissions;

public class EcommerceAbpFrameworkPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcommerceAbpFrameworkPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcommerceAbpFrameworkPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceAbpFrameworkResource>(name);
    }
}
