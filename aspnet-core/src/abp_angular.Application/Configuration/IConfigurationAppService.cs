using System.Threading.Tasks;
using abp_angular.Configuration.Dto;

namespace abp_angular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
