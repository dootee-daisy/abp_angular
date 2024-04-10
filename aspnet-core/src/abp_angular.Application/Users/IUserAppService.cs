using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abp_angular.Roles.Dto;
using abp_angular.Users.Dto;

namespace abp_angular.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
