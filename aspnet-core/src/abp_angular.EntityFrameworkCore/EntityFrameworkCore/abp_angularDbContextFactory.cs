using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abp_angular.Configuration;
using abp_angular.Web;

namespace abp_angular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class abp_angularDbContextFactory : IDesignTimeDbContextFactory<abp_angularDbContext>
    {
        public abp_angularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<abp_angularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            abp_angularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(abp_angularConsts.ConnectionStringName));

            return new abp_angularDbContext(builder.Options);
        }
    }
}
