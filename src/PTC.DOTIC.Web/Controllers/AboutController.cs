using System.Web.Mvc;

namespace PTC.DOTIC.Web.Controllers
{
    public class AboutController : DOTICControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}