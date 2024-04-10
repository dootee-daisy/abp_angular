using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abp_angular.Controllers
{
    public abstract class abp_angularControllerBase: AbpController
    {
        protected abp_angularControllerBase()
        {
            LocalizationSourceName = abp_angularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
