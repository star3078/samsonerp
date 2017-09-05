using System.Collections.Generic;
using Cloud.Samson.Authorization.Users.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}