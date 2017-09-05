using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Authorization.Permissions.Dto;

namespace Cloud.Samson.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}