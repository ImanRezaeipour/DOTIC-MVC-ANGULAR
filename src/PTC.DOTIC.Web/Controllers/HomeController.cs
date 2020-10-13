using System.Web.Mvc;

namespace PTC.DOTIC.Web.Controllers
{
    public class HomeController : DOTICControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}