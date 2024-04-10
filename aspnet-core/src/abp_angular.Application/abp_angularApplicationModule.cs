using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_angular.Authorization;

namespace abp_angular
{
    [DependsOn(
        typeof(abp_angularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class abp_angularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<abp_angularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(abp_angularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
