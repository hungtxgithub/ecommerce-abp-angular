using EcommerceAbpFramework.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EcommerceAbpFramework.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EcommerceAbpFrameworkEntityFrameworkCoreModule),
    typeof(EcommerceAbpFrameworkApplicationContractsModule)
    )]
public class EcommerceAbpFrameworkDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
