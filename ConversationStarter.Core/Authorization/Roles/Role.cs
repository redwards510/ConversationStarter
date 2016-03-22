using Abp.Authorization.Roles;
using ConversationStarter.MultiTenancy;
using ConversationStarter.Users;

namespace ConversationStarter.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}