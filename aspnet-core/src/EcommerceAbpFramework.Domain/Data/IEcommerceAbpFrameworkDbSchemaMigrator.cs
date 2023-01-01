using System.Threading.Tasks;

namespace EcommerceAbpFramework.Data;

public interface IEcommerceAbpFrameworkDbSchemaMigrator
{
    Task MigrateAsync();
}
