using System.Web.Mvc;
using Abp.Auditing;

namespace Cloud.Samson.Web.Controllers
{
    public class ErrorController : AbpZeroTemplateControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}