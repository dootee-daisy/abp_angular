using Abp.Authorization;
using abp_angular.Authorization.Roles;
using abp_angular.Authorization.Users;

namespace abp_angular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
