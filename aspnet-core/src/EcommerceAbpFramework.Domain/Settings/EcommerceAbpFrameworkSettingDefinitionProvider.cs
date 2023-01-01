using Volo.Abp.Settings;

namespace EcommerceAbpFramework.Settings;

public class EcommerceAbpFrameworkSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EcommerceAbpFrameworkSettings.MySetting1));
    }
}
