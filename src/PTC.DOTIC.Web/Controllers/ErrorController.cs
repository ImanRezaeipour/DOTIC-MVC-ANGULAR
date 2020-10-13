using System.Web.Mvc;
using Abp.Auditing;

namespace PTC.DOTIC.Web.Controllers
{
    public class ErrorController : DOTICControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}