using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using abp_angular.MultiTenancy;

namespace abp_angular.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
