using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Samson.Authorization.Permissions.Dto;

namespace Cloud.Samson.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
