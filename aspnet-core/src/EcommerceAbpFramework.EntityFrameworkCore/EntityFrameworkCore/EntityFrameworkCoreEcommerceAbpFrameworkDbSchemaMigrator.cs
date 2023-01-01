using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EcommerceAbpFramework.Data;
using Volo.Abp.DependencyInjection;

namespace EcommerceAbpFramework.EntityFrameworkCore;

public class EntityFrameworkCoreEcommerceAbpFrameworkDbSchemaMigrator
    : IEcommerceAbpFrameworkDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEcommerceAbpFrameworkDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EcommerceAbpFrameworkDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EcommerceAbpFrameworkDbContext>()
            .Database
            .MigrateAsync();
    }
}
