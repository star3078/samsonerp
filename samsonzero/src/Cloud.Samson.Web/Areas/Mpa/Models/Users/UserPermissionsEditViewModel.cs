using Abp.AutoMapper;
using Cloud.Samson.Authorization.Users;
using Cloud.Samson.Authorization.Users.Dto;
using Cloud.Samson.Web.Areas.Mpa.Models.Common;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}