using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace EcommerceAbpFramework;

[Dependency(ReplaceServices = true)]
public class EcommerceAbpFrameworkBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EcommerceAbpFramework";
}
