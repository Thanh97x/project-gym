using Abp.Authorization;
using Demotht.Authorization.Roles;
using Demotht.Authorization.Users;

namespace Demotht.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
