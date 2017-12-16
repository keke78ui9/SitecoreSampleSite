using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace SampleMvcSitecore.Controllers
{
    public class SampleController : SitecoreController
    {
        public ActionResult Module1()
        {
            return View();
        }
    }
}