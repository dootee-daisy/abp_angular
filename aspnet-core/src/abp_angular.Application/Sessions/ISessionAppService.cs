using System.Threading.Tasks;
using Abp.Application.Services;
using abp_angular.Sessions.Dto;

namespace abp_angular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
