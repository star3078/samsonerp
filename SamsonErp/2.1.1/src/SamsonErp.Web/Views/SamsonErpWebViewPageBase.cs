using Abp.Web.Mvc.Views;

namespace SamsonErp.Web.Views
{
    public abstract class SamsonErpWebViewPageBase : SamsonErpWebViewPageBase<dynamic>
    {

    }

    public abstract class SamsonErpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SamsonErpWebViewPageBase()
        {
            LocalizationSourceName = SamsonErpConsts.LocalizationSourceName;
        }
    }
}