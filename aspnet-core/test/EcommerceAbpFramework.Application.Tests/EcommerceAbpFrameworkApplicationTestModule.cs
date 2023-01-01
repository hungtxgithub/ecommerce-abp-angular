using Volo.Abp.Modularity;

namespace EcommerceAbpFramework;

[DependsOn(
    typeof(EcommerceAbpFrameworkApplicationModule),
    typeof(EcommerceAbpFrameworkDomainTestModule)
    )]
public class EcommerceAbpFrameworkApplicationTestModule : AbpModule
{

}
