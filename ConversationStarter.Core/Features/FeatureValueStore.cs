using Abp.Application.Features;
using ConversationStarter.Authorization.Roles;
using ConversationStarter.MultiTenancy;
using ConversationStarter.Users;

namespace ConversationStarter.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}