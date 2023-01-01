using System;
using System.Collections.Generic;
using System.Text;
using EcommerceAbpFramework.Localization;
using Volo.Abp.Application.Services;

namespace EcommerceAbpFramework;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAbpFrameworkAppService : ApplicationService
{
    protected EcommerceAbpFrameworkAppService()
    {
        LocalizationResource = typeof(EcommerceAbpFrameworkResource);
    }
}
