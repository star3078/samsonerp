using Abp.Authorization;
using SamsonErp.Authorization.Roles;
using SamsonErp.Authorization.Users;

namespace SamsonErp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
