using EcommerceAbpFramework.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EcommerceAbpFramework;

[DependsOn(
    typeof(EcommerceAbpFrameworkEntityFrameworkCoreTestModule)
    )]
public class EcommerceAbpFrameworkDomainTestModule : AbpModule
{

}
