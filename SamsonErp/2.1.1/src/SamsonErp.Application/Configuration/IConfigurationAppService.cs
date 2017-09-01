using System.Threading.Tasks;
using Abp.Application.Services;
using SamsonErp.Configuration.Dto;

namespace SamsonErp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}