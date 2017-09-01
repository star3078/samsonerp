using System.Collections.Generic;
using SamsonErp.Roles.Dto;
using SamsonErp.Users.Dto;

namespace SamsonErp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}