using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abp_angular.Authorization.Roles;
using abp_angular.Authorization.Users;
using abp_angular.MultiTenancy;

namespace abp_angular.EntityFrameworkCore
{
    public class abp_angularDbContext : AbpZeroDbContext<Tenant, Role, User, abp_angularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public abp_angularDbContext(DbContextOptions<abp_angularDbContext> options)
            : base(options)
        {
        }
    }
}
