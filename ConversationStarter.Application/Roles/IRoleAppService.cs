using System.Threading.Tasks;
using Abp.Application.Services;
using ConversationStarter.Roles.Dto;

namespace ConversationStarter.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
