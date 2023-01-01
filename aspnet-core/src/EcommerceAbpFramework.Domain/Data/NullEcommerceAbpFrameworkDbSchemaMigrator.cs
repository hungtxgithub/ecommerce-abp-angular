using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EcommerceAbpFramework.Data;

/* This is used if database provider does't define
 * IEcommerceAbpFrameworkDbSchemaMigrator implementation.
 */
public class NullEcommerceAbpFrameworkDbSchemaMigrator : IEcommerceAbpFrameworkDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
