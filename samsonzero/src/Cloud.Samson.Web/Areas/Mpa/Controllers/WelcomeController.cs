using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Cloud.Samson.Web.Controllers;

namespace Cloud.Samson.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}