using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ConversationStarter.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ConversationStarterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}