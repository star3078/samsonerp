using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Authorization.Permissions.Dto;

namespace Cloud.Samson.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}