using Abp.Authorization;
using ConversationStarter.Authorization.Roles;
using ConversationStarter.MultiTenancy;
using ConversationStarter.Users;

namespace ConversationStarter.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
