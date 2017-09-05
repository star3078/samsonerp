using System.Threading.Tasks;
using Abp.Configuration;

namespace Cloud.Samson.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
