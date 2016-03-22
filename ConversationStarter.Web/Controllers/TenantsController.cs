using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ConversationStarter.Authorization;
using ConversationStarter.MultiTenancy;

namespace ConversationStarter.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ConversationStarterControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}