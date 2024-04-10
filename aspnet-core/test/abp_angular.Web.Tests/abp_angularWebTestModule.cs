using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_angular.EntityFrameworkCore;
using abp_angular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace abp_angular.Web.Tests
{
    [DependsOn(
        typeof(abp_angularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class abp_angularWebTestModule : AbpModule
    {
        public abp_angularWebTestModule(abp_angularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abp_angularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(abp_angularWebMvcModule).Assembly);
        }
    }
}