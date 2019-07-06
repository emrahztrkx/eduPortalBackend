using Abp.Authorization;
using educationPortal.Authorization.Roles;
using educationPortal.Authorization.Users;

namespace educationPortal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
