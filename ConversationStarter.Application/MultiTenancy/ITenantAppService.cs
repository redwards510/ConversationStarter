using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ConversationStarter.MultiTenancy.Dto;

namespace ConversationStarter.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
