using System.Web.Mvc;

namespace ConversationStarter.Web.Controllers
{
    public class AboutController : ConversationStarterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}