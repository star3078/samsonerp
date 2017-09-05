using Abp.Application.Services;
using Cloud.Samson.Tenants.Dashboard.Dto;

namespace Cloud.Samson.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
