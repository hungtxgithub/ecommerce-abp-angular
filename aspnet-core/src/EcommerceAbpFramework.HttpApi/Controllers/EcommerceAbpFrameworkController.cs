using EcommerceAbpFramework.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EcommerceAbpFramework.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceAbpFrameworkController : AbpControllerBase
{
    protected EcommerceAbpFrameworkController()
    {
        LocalizationResource = typeof(EcommerceAbpFrameworkResource);
    }
}
