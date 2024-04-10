using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_angular.Configuration;

namespace abp_angular.Web.Host.Startup
{
    [DependsOn(
       typeof(abp_angularWebCoreModule))]
    public class abp_angularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abp_angularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abp_angularWebHostModule).GetAssembly());
        }
    }
}
