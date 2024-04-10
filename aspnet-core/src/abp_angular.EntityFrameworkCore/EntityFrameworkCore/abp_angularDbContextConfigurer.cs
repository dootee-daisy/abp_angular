using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abp_angular.EntityFrameworkCore
{
    public static class abp_angularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<abp_angularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<abp_angularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
