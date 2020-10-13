using Abp.Authorization;
using PTC.DOTIC.Authorization.Roles;
using PTC.DOTIC.Authorization.Users;
using PTC.DOTIC.MultiTenancy;

namespace PTC.DOTIC.Authorization
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
