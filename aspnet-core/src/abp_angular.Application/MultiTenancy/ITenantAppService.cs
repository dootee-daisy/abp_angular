using Abp.Application.Services;
using abp_angular.MultiTenancy.Dto;

namespace abp_angular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

