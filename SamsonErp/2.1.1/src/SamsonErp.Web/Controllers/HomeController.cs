using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SamsonErp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SamsonErpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}