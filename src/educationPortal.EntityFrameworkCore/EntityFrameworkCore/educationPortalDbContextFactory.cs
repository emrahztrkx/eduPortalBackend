using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using educationPortal.Configuration;
using educationPortal.Web;

namespace educationPortal.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class educationPortalDbContextFactory : IDesignTimeDbContextFactory<educationPortalDbContext>
    {
        public educationPortalDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<educationPortalDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            educationPortalDbContextConfigurer.Configure(builder, configuration.GetConnectionString(educationPortalConsts.ConnectionStringName));

            return new educationPortalDbContext(builder.Options);
        }
    }
}
