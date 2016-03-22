using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ConversationStarter.Authorization.Roles;
using ConversationStarter.Editions;
using ConversationStarter.Users;

namespace ConversationStarter.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}