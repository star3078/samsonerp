using Abp.AutoMapper;
using Cloud.Samson.MultiTenancy;
using Cloud.Samson.MultiTenancy.Dto;
using Cloud.Samson.Web.Areas.Mpa.Models.Common;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}