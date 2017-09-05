using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.Samson.Configuration.Tenants.Dto;

namespace Cloud.Samson.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
