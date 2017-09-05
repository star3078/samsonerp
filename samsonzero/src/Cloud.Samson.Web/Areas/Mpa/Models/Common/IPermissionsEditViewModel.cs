using System.Collections.Generic;
using Cloud.Samson.Authorization.Permissions.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}