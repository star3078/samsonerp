using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.Samson.Configuration.Host.Dto;

namespace Cloud.Samson.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
