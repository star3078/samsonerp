using Abp.Authorization;
using Cloud.Samson.Authorization.Roles;
using Cloud.Samson.Authorization.Users;
using Cloud.Samson.MultiTenancy;

namespace Cloud.Samson.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
