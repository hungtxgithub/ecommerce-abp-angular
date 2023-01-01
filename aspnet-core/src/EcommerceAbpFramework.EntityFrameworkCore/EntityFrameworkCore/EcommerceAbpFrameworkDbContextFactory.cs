using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EcommerceAbpFramework.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class EcommerceAbpFrameworkDbContextFactory : IDesignTimeDbContextFactory<EcommerceAbpFrameworkDbContext>
{
    public EcommerceAbpFrameworkDbContext CreateDbContext(string[] args)
    {
        EcommerceAbpFrameworkEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EcommerceAbpFrameworkDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new EcommerceAbpFrameworkDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EcommerceAbpFramework.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
