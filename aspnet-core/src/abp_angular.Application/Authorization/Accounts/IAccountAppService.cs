using System.Threading.Tasks;
using Abp.Application.Services;
using abp_angular.Authorization.Accounts.Dto;

namespace abp_angular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
