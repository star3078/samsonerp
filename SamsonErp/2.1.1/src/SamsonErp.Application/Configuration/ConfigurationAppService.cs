using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SamsonErp.Configuration.Dto;

namespace SamsonErp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SamsonErpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
