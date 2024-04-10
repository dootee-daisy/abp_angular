using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abp_angular.Configuration.Dto;

namespace abp_angular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : abp_angularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
