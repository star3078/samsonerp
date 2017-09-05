using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Cloud.Samson.Authorization;
using Cloud.Samson.Web.Controllers;

namespace Cloud.Samson.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}